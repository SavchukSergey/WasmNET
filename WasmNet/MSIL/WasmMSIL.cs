using System;
using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL : IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult> {

        public static DynamicMethod Compile(WasmFunctionSignature sig, WasmFunctionBody func) {
            var arg = new WasmMSILArg(sig);
            var visitor = new WasmMSIL();
            foreach (var opcode in func.Opcodes) {
                opcode.AcceptVistor(visitor, arg);
            }
            return arg.Method;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BaseOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

    }

}
