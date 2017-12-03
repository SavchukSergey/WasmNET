namespace WasmNet.Opcodes {
    public class I32AddOpcode : I32UBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override uint Execute(uint left, uint right) => left + right;

        public override string ToString() => "i32.add";

    }
}
