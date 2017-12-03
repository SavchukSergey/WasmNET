namespace WasmNet.Opcodes {
    public class I64EqzOpcode : I64UnaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(ulong value) => value == 0;

        public override string ToString() => "i64.eqz";

    }
}
