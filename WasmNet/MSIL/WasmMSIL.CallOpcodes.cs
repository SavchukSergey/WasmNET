using System;
using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region CallOpcodes

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(CallOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(CallIndirectOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(DropOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(SelectOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        #endregion

 }

}
