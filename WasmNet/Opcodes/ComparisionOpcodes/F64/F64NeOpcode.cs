namespace WasmNet.Opcodes {
    public class F64NeOpcode : F64BinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(double left, double right) => left != right;

        public override string ToString() => "f64.ne";

    }
}
