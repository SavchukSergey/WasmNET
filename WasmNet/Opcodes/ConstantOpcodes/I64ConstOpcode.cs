namespace WasmNet.Opcodes {
    public class I64ConstOpcode : BaseOpcode {

        public I64ConstOpcode(long value) {
            Value = value;
        }

        public long Value { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i64.const {Value}";

    }
}
