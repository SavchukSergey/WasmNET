namespace WasmNet.Opcodes {
    public interface IWasmOpcodeVisitor<TArg, TResult> {

        #region ControlFlowOpcodes

        TResult Visit(UnreachableOpcode opcode, TArg arg);

        TResult Visit(NopOpcode opcode, TArg arg);

        TResult Visit(BlockOpcode opcode, TArg arg);

        TResult Visit(LoopOpcode opcode, TArg arg);

        TResult Visit(IfOpcode opcode, TArg arg);

        TResult Visit(ElseOpcode opcode, TArg arg);

        TResult Visit(EndOpcode opcode, TArg arg);

        TResult Visit(BrOpcode opcode, TArg arg);

        TResult Visit(BrIfOpcode opcode, TArg arg);

        TResult Visit(BrTableOpcode opcode, TArg arg);

        TResult Visit(ReturnOpcode opcode, TArg arg);

        #endregion

        #region CallOpcodes

        TResult Visit(CallOpcode opcode, TArg arg);

        TResult Visit(CallIndirectOpcode opcode, TArg arg);

        #endregion

        #region ParamtericOpcodes

        TResult Visit(DropOpcode opcode, TArg arg);

        TResult Visit(SelectOpcode opcode, TArg arg);

        #endregion

        #region VariableOpcodes

        TResult Visit(GetLocalOpcode opcode, TArg arg);

        TResult Visit(SetLocalOpcode opcode, TArg arg);

        TResult Visit(TeeLocalOpcode opcode, TArg arg);

        TResult Visit(GetGlobalOpcode opcode, TArg arg);

        TResult Visit(SetGlobalOpcode opcode, TArg arg);

        #endregion

        #region ConstantOpcodes

        TResult Visit(I32ConstOpcode opcode, TArg arg);

        TResult Visit(I64ConstOpcode opcode, TArg arg);

        TResult Visit(F32ConstOpcode opcode, TArg arg);

        TResult Visit(F64ConstOpcode opcode, TArg arg);

        #endregion

        #region ComparisionOpcodes

        TResult Visit(I32EqzOpcode opcode, TArg arg);

        #endregion

        #region NumericOpcodes

        #region I32

        TResult Visit(I32AddOpcode opcode, TArg arg);

        TResult Visit(I32AndOpcode opcode, TArg arg);

        #endregion

        #endregion

        TResult Visit(BaseOpcode opcode, TArg arg);

    }
}
