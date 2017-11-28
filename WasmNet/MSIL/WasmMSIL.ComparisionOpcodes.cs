using System;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region ComparisionOpcodesOpcodes

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32EqzOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32NeOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(I32LtuOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        #endregion

    }
}
