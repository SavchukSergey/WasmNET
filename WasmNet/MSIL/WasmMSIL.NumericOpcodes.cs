using System;
using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region NumericOpcodes

        #region I32

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32AddOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Add);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32AndOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.And);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32XorOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Xor);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32ShlOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Shl);
            return null;
        }

        #endregion

        #region I64

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64AddOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Add);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64AndOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.And);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64XorOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Xor);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64ShlOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Shl);
            return null;
        }

        #endregion

        #endregion

    }

}
