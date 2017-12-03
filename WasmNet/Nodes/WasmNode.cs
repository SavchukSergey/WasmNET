using System;
using WasmNet.Data;
using WasmNet.Opcodes;
using WasmNet.Sections;

namespace WasmNet.Nodes {
    public partial class WasmNode : IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult> {

        private static void DeclareGlobals(WasmNodeContext context, WasmGlobalSection section) {
            foreach (var global in section.Entries) {
                var variable = new GlobalNode (global.Type.Type, global.Type.Mutable) {
                    Name = $"global_{context.Module.Globals.Count}"
                };
                context.Module.Globals.Add(variable);
            }
        }

        private static void DeclareFunctions(WasmNodeContext context, WasmFunctionSection funcSection, WasmTypeSection typeSection) {
            for (var i = 0; i < funcSection.Entries.Count; i++) {
                var func = funcSection.Entries[i];
                var sig = typeSection.Entries[(int)func];
                var node = new FunctionNode(sig) {
                    Name = $"func_{i}",
                    Execution = new NodesList(sig.Return)
                };
                context.Module.Functions.Add(node);
            }
        }

        private static void AddGlobals(WasmNodeContext context, WasmGlobalSection section) {
            DeclareGlobals(context, section);
            for (var i = 0; i < section.Entries.Count; i++) {
                var global = section.Entries[i];
                var variable = context.Module.Globals[i];

                var arg = new WasmNodeArg {
                    Context = context
                };
                arg.PushBlock(variable.Init);
                var visitor = new WasmNode();
                foreach (var opcode in global.Init.Opcodes) {
                    opcode.AcceptVistor(visitor, arg);
                }
            }
        }

        public static void Compile(WasmModule module) {
            var funcSection = module.ReadFunctionSection();
            var codeSection = module.ReadCodeSection();
            var typeSection = module.ReadTypeSection();
            var importSection = module.ReadImportSection();
            var globalSection = module.ReadGlobalSection();

            var moduleNode = new ModuleNode();

            var context = new WasmNodeContext {
                Module = moduleNode
            };

            foreach (var type in typeSection.Entries) {
                context.Types.Add(type);
            }

            foreach (var import in importSection.Entries) {
                switch (import.Kind) {
                    case WasmExternalKind.Function:
                        var type = typeSection.Entries[(int)import.TypeIndex];
                        var function = new FunctionNode(type) {
                            Name = $"{import.Module}_{import.Field}"
                        };
                        moduleNode.ImportedFunctions.Add(function);
                        moduleNode.Imports.Add(new ImportNode {
                            Module = import.Module,
                            Field = import.Field,
                            Node = function
                        });
                        break;
                    case WasmExternalKind.Global:
                        var global = new GlobalNode (import.Global.Type, import.Global.Mutable) {
                            Name = $"{import.Module}_{import.Field}"
                        };
                        moduleNode.ImportedGlobals.Add(global);
                        moduleNode.Imports.Add(new ImportNode {
                            Module = import.Module,
                            Field = import.Field,
                            Node = global
                        });
                        break;
                }
            }

            AddGlobals(context, globalSection);

            DeclareFunctions(context, funcSection, typeSection);

            for (var i = 0; i < codeSection.Bodies.Count; i++) {
                var code = codeSection.Bodies[i];
                var func = moduleNode.Functions[i];

                var arg = new WasmFunctionNodeArg(func) {
                    Context = context
                };

                foreach (var local in code.Locals) {
                    func.AddLocals(local.Type, local.Count);
                }

                arg.PushBlock(func.Execution);
                var visitor = new WasmNode();
                foreach (var opcode in code.Opcodes) {
                    opcode.AcceptVistor(visitor, arg);
                }

            }

            var writer = new NodeWriter();
            moduleNode.ToString(writer);
            Console.WriteLine(writer.ToString());
            Console.WriteLine();
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BaseOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();

    }
}
