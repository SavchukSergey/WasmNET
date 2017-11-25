using System;
using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region ControlFlowOpcodes

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(UnreachableOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(NopOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BlockOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(LoopOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(IfOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(ElseOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(EndOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ret);
            //todo: finalize current block
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BrOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BrIfOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(BrTableOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(ReturnOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        #endregion

    }

}
