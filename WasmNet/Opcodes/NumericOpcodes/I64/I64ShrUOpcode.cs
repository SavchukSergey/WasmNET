namespace WasmNet.Opcodes {
    public class I64ShrUOpcode : I64UBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override ulong Execute(ulong left, ulong right) => left >> (int)right;

        public override string ToString() => "i64.shr_u";

    }
}
