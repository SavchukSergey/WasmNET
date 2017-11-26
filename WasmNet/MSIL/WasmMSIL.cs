using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using WasmNet.Data;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL : IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult> {

        public static AssemblyBuilder Compile(WasmModule module, string className, string assemblyName) {
            var assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.RunAndCollect);
            var m = assembly.DefineDynamicModule(assemblyName);
            var type = m.DefineType(className);

            var funcSection = module.ReadFunctionSection();
            var codeSection = module.ReadCodeSection();
            var typeSection = module.ReadTypeSection();

            for (var i = 0; i < funcSection.Entries.Count; i++) {
                var func = funcSection.Entries[0];
                var sig = typeSection.Entries[(int)func];
                var code = codeSection.Bodies[i];

                var method = type.DefineMethod($"func_{i}", MethodAttributes.Private, Convert(sig.Return), sig.Parameters.Select(p => Convert(p)).ToArray());
                var ilGen = method.GetILGenerator();

                var arg = new WasmMSILArg(ilGen);
                var visitor = new WasmMSIL();
                foreach (var opcode in code.Opcodes) {
                    opcode.AcceptVistor(visitor, arg);
                }
            }
            return assembly;
        }

        private static Type Convert(WasmType? type) {
            switch (type) {
                case null: return typeof(void);
                case WasmType.BlockType: return typeof(void);
                case WasmType.I32: return typeof(int);
                case WasmType.I64: return typeof(long);
                case WasmType.F32: return typeof(float);
                case WasmType.F64: return typeof(double);
                default:
                    throw new WasmMSILCompilationException($"unknown type {type}");
            }
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BaseOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

    }

}
