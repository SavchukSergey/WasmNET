namespace WasmNet.Opcodes {
    public class I64DivSOpcode : I64SBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override long Execute(long left, long right) => left / right;

        public override string ToString() => "i64.div_s";

    }
}
