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

        #region I32

        TResult Visit(I32LoadOpcode opcode, TArg arg);

        TResult Visit(I32Load8SOpcode opcode, TArg arg);

        TResult Visit(I32Load8UOpcode opcode, TArg arg);

        TResult Visit(I32Load16SOpcode opcode, TArg arg);

        TResult Visit(I32Load16UOpcode opcode, TArg arg);

        TResult Visit(I32StoreOpcode opcode, TArg arg);

        TResult Visit(I32Store8Opcode opcode, TArg arg);

        TResult Visit(I32Store16Opcode opcode, TArg arg);

        #endregion

        #region I64

        TResult Visit(I64LoadOpcode opcode, TArg arg);

        TResult Visit(I64Load8SOpcode opcode, TArg arg);

        TResult Visit(I64Load8UOpcode opcode, TArg arg);

        TResult Visit(I64Load16SOpcode opcode, TArg arg);

        TResult Visit(I64Load16UOpcode opcode, TArg arg);

        TResult Visit(I64Load32SOpcode opcode, TArg arg);

        TResult Visit(I64Load32UOpcode opcode, TArg arg);

        TResult Visit(I64StoreOpcode opcode, TArg arg);

        TResult Visit(I64Store8Opcode opcode, TArg arg);

        TResult Visit(I64Store16Opcode opcode, TArg arg);

        TResult Visit(I64Store32Opcode opcode, TArg arg);

        #endregion

        #region F32

        TResult Visit(F32LoadOpcode opcode, TArg arg);

        TResult Visit(F32StoreOpcode opcode, TArg arg);

        #endregion

        #region F64

        TResult Visit(F64LoadOpcode opcode, TArg arg);

        TResult Visit(F64StoreOpcode opcode, TArg arg);

        #endregion

        TResult Visit(CurrentMemoryOpcode opcode, TArg arg);

        TResult Visit(GrowMemoryOpcode opcode, TArg arg);

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

        TResult Visit(I32LesOpcode opcode, TArg arg);

        TResult Visit(I32LeuOpcode opcode, TArg arg);

        TResult Visit(I32GesOpcode opcode, TArg arg);

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

        TResult Visit(I64LesOpcode opcode, TArg arg);

        TResult Visit(I64LeuOpcode opcode, TArg arg);

        TResult Visit(I64GesOpcode opcode, TArg arg);

        TResult Visit(I64GeuOpcode opcode, TArg arg);

        #endregion

        #region F32

        TResult Visit(F32EqOpcode opcode, TArg arg);

        TResult Visit(F32NeOpcode opcode, TArg arg);

        TResult Visit(F32LtOpcode opcode, TArg arg);

        TResult Visit(F32GtOpcode opcode, TArg arg);

        TResult Visit(F32LeOpcode opcode, TArg arg);

        TResult Visit(F32GeOpcode opcode, TArg arg);

        #endregion

        #region F64

        TResult Visit(F64EqOpcode opcode, TArg arg);

        TResult Visit(F64NeOpcode opcode, TArg arg);

        TResult Visit(F64LtOpcode opcode, TArg arg);

        TResult Visit(F64GtOpcode opcode, TArg arg);

        TResult Visit(F64LeOpcode opcode, TArg arg);

        TResult Visit(F64GeOpcode opcode, TArg arg);

        #endregion

        #endregion

        #region NumericOpcodes

        #region I32

        TResult Visit(I32AddOpcode opcode, TArg arg);

        TResult Visit(I32SubOpcode opcode, TArg arg);

        TResult Visit(I32MulOpcode opcode, TArg arg);

        TResult Visit(I32DivSOpcode opcode, TArg arg);

        TResult Visit(I32DivUOpcode opcode, TArg arg);

        TResult Visit(I32RemUOpcode opcode, TArg arg);

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

        TResult Visit(I64MulOpcode opcode, TArg arg);

        TResult Visit(I64DivSOpcode opcode, TArg arg);

        TResult Visit(I64DivUOpcode opcode, TArg arg);

        TResult Visit(I64RemUOpcode opcode, TArg arg);

        TResult Visit(I64AndOpcode opcode, TArg arg);

        TResult Visit(I64OrOpcode opcode, TArg arg);

        TResult Visit(I64XorOpcode opcode, TArg arg);

        TResult Visit(I64ShlOpcode opcode, TArg arg);

        TResult Visit(I64ShrSOpcode opcode, TArg arg);

        TResult Visit(I64ShrUOpcode opcode, TArg arg);

        #endregion

        #region F32

        TResult Visit(F32AbsOpcode opcode, TArg arg);

        TResult Visit(F32NegOpcode opcode, TArg arg);

        #endregion

        #region F64

        TResult Visit(F64AbsOpcode opcode, TArg arg);

        TResult Visit(F64NegOpcode opcode, TArg arg);

        #endregion

        #endregion

        #region ConversionOpcodes

        #region I32

        TResult Visit(I32WrapI64Opcode opcode, TArg arg);

        TResult Visit(I32TruncSF32Opcode opcode, TArg arg);

        TResult Visit(I32TruncUF32Opcode opcode, TArg arg);

        TResult Visit(I32TruncSF64Opcode opcode, TArg arg);

        TResult Visit(I32TruncUF64Opcode opcode, TArg arg);

        #endregion

        #region I64

        TResult Visit(I64ExtendSI32Opcode opcode, TArg arg);

        TResult Visit(I64ExtendUI32Opcode opcode, TArg arg);

        TResult Visit(I64TruncSF32Opcode opcode, TArg arg);

        TResult Visit(I64TruncUF32Opcode opcode, TArg arg);

        TResult Visit(I64TruncSF64Opcode opcode, TArg arg);

        TResult Visit(I64TruncUF64Opcode opcode, TArg arg);

        #endregion

        #region F32

        TResult Visit(F32ConvertSI32Opcode opcode, TArg arg);

        TResult Visit(F32ConvertUI32Opcode opcode, TArg arg);

        TResult Visit(F32ConvertSI64Opcode opcode, TArg arg);

        TResult Visit(F32ConvertUI64Opcode opcode, TArg arg);

        TResult Visit(F32DemoteF64Opcode opcode, TArg arg);

        #endregion

        #region F64

        TResult Visit(F64ConvertSI32Opcode opcode, TArg arg);

        TResult Visit(F64ConvertUI32Opcode opcode, TArg arg);

        TResult Visit(F64ConvertSI64Opcode opcode, TArg arg);

        TResult Visit(F64ConvertUI64Opcode opcode, TArg arg);

        TResult Visit(F64PromoteF32Opcode opcode, TArg arg);

        #endregion

        #endregion

        TResult Visit(BaseOpcode opcode, TArg arg);

    }
}
