namespace WasmNet.Opcodes {
    public class I32EqzOpcode : I32UnaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(uint value) => value == 0;

        public override string ToString() => "i32.eqz";
    }
}
