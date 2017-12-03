namespace WasmNet.Opcodes {
    public class I64AndOpcode : I64UBinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override ulong Execute(ulong left, ulong right) => left & right;

        public override string ToString() => "i64.and";

    }
}
