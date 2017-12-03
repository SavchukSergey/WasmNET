namespace WasmNet.Opcodes {
    public class I32GesOpcode : I32SBinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(int left, int right) => left >= right;

        public override string ToString() => "i32.ge_s";

    }
}
