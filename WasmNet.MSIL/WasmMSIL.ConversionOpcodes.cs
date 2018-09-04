using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32WrapI64Opcode opcode, WasmMSILArg arg) {
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64ExtendUI32Opcode opcode, WasmMSILArg arg) {
            return null;
        }

    }
}
