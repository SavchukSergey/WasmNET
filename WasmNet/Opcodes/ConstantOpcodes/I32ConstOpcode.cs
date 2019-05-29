namespace WasmNet.Opcodes {
    public class I32ConstOpcode : BaseOpcode {

        public I32ConstOpcode(int value) {
            Value = value;
        }

        public int Value { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            state.PushSI32(Value);
        }

        public override string ToString() => $"i32.const {Value}";

    }
}
