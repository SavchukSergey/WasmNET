using System;
using System.Reflection.Emit;
using WasmNet.Opcodes;

namespace WasmNet.MSIL {
    public partial class WasmMSIL {

        #region VariableOpcodes

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(GetLocalOpcode opcode, WasmMSILArg arg) {
            arg.IL.Emit(OpCodes.Ldarg, opcode.LocalIndex);
            return null;
        }

        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(SetLocalOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(TeeLocalOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(GetGlobalOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();
        WasmMSILResult IWasmOpcodeVisitor<WasmMSILArg, WasmMSILResult>.Visit(SetGlobalOpcode opcode, WasmMSILArg arg) => throw new NotImplementedException();

        #endregion

    }

}
