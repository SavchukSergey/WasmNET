namespace WasmNet.Opcodes {
    public class I32GeuOpcode : I32UBinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(uint left, uint right) => left >= right;

        public override string ToString() => "i32.ge_u";

    }
}
