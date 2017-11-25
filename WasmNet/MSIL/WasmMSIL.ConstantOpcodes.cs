using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region ConstantOpcodes

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32ConstOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ldc_I4, opcode.Value);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64ConstOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ldc_I8, opcode.Value);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(F32ConstOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ldc_R4, opcode.Value);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(F64ConstOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ldc_R8, opcode.Value);
            return null;
        }

        #endregion

    }
}
