namespace WasmNet.Opcodes {
    public class F64NegOpcode : F64UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double arg) => -arg;

        public override string ToString() => "f64.neg";

    }
}
