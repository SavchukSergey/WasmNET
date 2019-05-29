namespace WasmNet.Opcodes {
    public class F32DivOpcode : F32NumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "f32.div";

    }
}
