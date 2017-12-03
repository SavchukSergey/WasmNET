namespace WasmNet.Opcodes {
    public class F32EqOpcode : F32BinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(float left, float right) => left == right;

        public override string ToString() => "f32.eq";

    }
}
