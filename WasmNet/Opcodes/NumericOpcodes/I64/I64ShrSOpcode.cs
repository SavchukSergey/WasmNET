namespace WasmNet.Opcodes {
    public class I64ShrSOpcode : I64SBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override long Execute(long left, long right) => left >> (int)right;

        public override string ToString() => "i64.shr_s";

    }
}
