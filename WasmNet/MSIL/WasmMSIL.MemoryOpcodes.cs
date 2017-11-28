using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region MemoryOpcodes

        #region I32

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32LoadOpcode opcode, WasmMSILArg arg) {
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32StoreOpcode opcode, WasmMSILArg arg) {
            return null;
        }

        #endregion

        #region I64

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64LoadOpcode opcode, WasmMSILArg arg) {
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I64StoreOpcode opcode, WasmMSILArg arg) {
            return null;
        }

        #endregion

        #endregion

    }

}
