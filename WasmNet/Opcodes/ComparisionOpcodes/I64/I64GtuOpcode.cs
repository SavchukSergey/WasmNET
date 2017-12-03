namespace WasmNet.Opcodes {
    public class I64GtuOpcode : I64UBinaryComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override bool Compare(ulong left, ulong right) => left > right;

        public override string ToString() => "i64.gt_u";

    }
}
