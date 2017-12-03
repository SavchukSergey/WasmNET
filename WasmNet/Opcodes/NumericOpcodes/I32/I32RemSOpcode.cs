namespace WasmNet.Opcodes {
    public class I32RemSOpcode : I32SBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override int Execute(int left, int right) => left % right;

        public override string ToString() => "i32.rem_s";

    }
}
