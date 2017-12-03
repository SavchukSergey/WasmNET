namespace WasmNet.Opcodes {
    public class F32NegOpcode : F32UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(float arg) => -arg;

        public override string ToString() => "f32.neg";

    }
}
