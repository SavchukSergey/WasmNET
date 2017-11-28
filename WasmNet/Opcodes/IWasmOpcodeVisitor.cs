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

        #region MemoryOpcodes

        TResult Visit(I32LoadOpcode opcode, TArg arg);

        TResult Visit(I32Load8SOpcode opcode, TArg arg);

        TResult Visit(I32Load8UOpcode opcode, TArg arg);

        TResult Visit(I64LoadOpcode opcode, TArg arg);

        TResult Visit(I32StoreOpcode opcode, TArg arg);

        TResult Visit(I64StoreOpcode opcode, TArg arg);

        TResult Visit(I32Store8Opcode opcode, TArg arg);

        TResult Visit(I64Store8Opcode opcode, TArg arg);

        TResult Visit(I64Store32Opcode opcode, TArg arg);
        
        #endregion

        #region ConstantOpcodes

        TResult Visit(I32ConstOpcode opcode, TArg arg);

        TResult Visit(I64ConstOpcode opcode, TArg arg);

        TResult Visit(F32ConstOpcode opcode, TArg arg);

        TResult Visit(F64ConstOpcode opcode, TArg arg);

        #endregion

        #region ComparisionOpcodes

        #region I32

        TResult Visit(I32EqzOpcode opcode, TArg arg);

        TResult Visit(I32EqOpcode opcode, TArg arg);

        TResult Visit(I32NeOpcode opcode, TArg arg);

        TResult Visit(I32LtsOpcode opcode, TArg arg);

        TResult Visit(I32LtuOpcode opcode, TArg arg);
        
        TResult Visit(I32GtsOpcode opcode, TArg arg);

        TResult Visit(I32GtuOpcode opcode, TArg arg);

        TResult Visit(I32GeuOpcode opcode, TArg arg);

        #endregion

        #region I64

        TResult Visit(I64EqzOpcode opcode, TArg arg);

        TResult Visit(I64EqOpcode opcode, TArg arg);

        TResult Visit(I64NeOpcode opcode, TArg arg);

        TResult Visit(I64LtsOpcode opcode, TArg arg);

        TResult Visit(I64LtuOpcode opcode, TArg arg);

        TResult Visit(I64GtsOpcode opcode, TArg arg);

        TResult Visit(I64GtuOpcode opcode, TArg arg);

        TResult Visit(I64GeuOpcode opcode, TArg arg);

        #endregion

        #endregion

        #region NumericOpcodes

        #region I32

        TResult Visit(I32AddOpcode opcode, TArg arg);

        TResult Visit(I32SubOpcode opcode, TArg arg);

        TResult Visit(I32DivSOpcode opcode, TArg arg);

        TResult Visit(I32AndOpcode opcode, TArg arg);

        TResult Visit(I32OrOpcode opcode, TArg arg);

        TResult Visit(I32XorOpcode opcode, TArg arg);

        TResult Visit(I32ShlOpcode opcode, TArg arg);

        TResult Visit(I32ShrSOpcode opcode, TArg arg);

        TResult Visit(I32ShrUOpcode opcode, TArg arg);

        #endregion

        #region I64

        TResult Visit(I64AddOpcode opcode, TArg arg);

        TResult Visit(I64SubOpcode opcode, TArg arg);

        TResult Visit(I64DivSOpcode opcode, TArg arg);

        TResult Visit(I64AndOpcode opcode, TArg arg);

        TResult Visit(I64OrOpcode opcode, TArg arg);

        TResult Visit(I64XorOpcode opcode, TArg arg);

        TResult Visit(I64ShlOpcode opcode, TArg arg);

        TResult Visit(I64ShrSOpcode opcode, TArg arg);

        TResult Visit(I64ShrUOpcode opcode, TArg arg);

        #endregion

        #endregion

        #region ConversionOpcodes

        #region I32

        TResult Visit(I32WrapI64Opcode opcode, TArg arg);

        #endregion

        #region I64

        TResult Visit(I64ExtendSI32Opcode opcode, TArg arg);

        TResult Visit(I64ExtendUI32Opcode opcode, TArg arg);

        #endregion

        #endregion

        TResult Visit(BaseOpcode opcode, TArg arg);

    }
}
