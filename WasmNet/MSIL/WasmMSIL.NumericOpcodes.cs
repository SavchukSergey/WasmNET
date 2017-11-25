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

        #endregion

        #endregion

    }

}
