﻿using System;
using WasmNet.Opcodes;

namespace WasmNet.Nodes {
    public partial class WasmNode : IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult> {

        public static void Compile(WasmModule module) {
            var funcSection = module.ReadFunctionSection();
            var codeSection = module.ReadCodeSection();
            var typeSection = module.ReadTypeSection();
            var importSection = module.ReadImportSection();

            var context = new WasmNodeContext();
            foreach (var import in importSection.Entries) {
                if (import.Kind == Data.WasmExternalKind.Function) {
                    var type = typeSection.Entries[(int)import.TypeIndex];
                    context.ImportedFunctions.Add(new FunctionNode(type) {
                        Name = $"{import.Module}.{import.Field}"
                    });
                }
            }

            for (var i = 0; i < funcSection.Entries.Count; i++) {
                var func = funcSection.Entries[0];
                var sig = typeSection.Entries[(int)func];
                var node = new FunctionNode(sig) {
                    Name = $"func_{i}",
                    Execution = new BlockNode()
                };
                context.Functions.Add(node);
            }

            for (var i = 0; i < codeSection.Bodies.Count; i++) {
                var code = codeSection.Bodies[i];
                var func = context.Functions[i];

                var arg = new WasmNodeArg(func) {
                    Context = context
                };

                foreach(var local in code.Locals) {
                    func.AddLocals(local.Type, local.Count);
                }

                arg.PushBlock(func.Execution);
                var visitor = new WasmNode();
                foreach (var opcode in code.Opcodes) {
                    opcode.AcceptVistor(visitor, arg);
                }
                //if (arg.Stack.Count > 0) {
                //    arg.Execution.Add(new ReturnNode(arg.Stack.Pop()));
                //}

                var writer = new NodeWriter();
                func.ToSExpressionString(writer);

                Console.WriteLine(writer.ToString());
                Console.WriteLine();
            }
        }

        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(DropOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(SelectOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
        WasmNodeResult IWasmOpcodeVisitor<WasmNodeArg, WasmNodeResult>.Visit(BaseOpcode opcode, WasmNodeArg arg) => throw new System.NotImplementedException();
    }
}
