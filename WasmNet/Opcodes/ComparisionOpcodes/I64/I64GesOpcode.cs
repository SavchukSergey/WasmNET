namespace WasmNet.Opcodes {
    public class I64GesOpcode : I64SBinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(long left, long right) => left >= right;

        public override string ToString() => "i64.ge_s";

    }
}
