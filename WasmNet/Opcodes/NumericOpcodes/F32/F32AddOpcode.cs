namespace WasmNet.Opcodes {
    public class F32AddOpcode : F32BinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override float Execute(float left, float right) => left + right;

        public override string ToString() => "f32.add";

    }
}
