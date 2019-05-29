namespace WasmNet.Opcodes {
    public class CallOpcode : BaseOpcode {

        public CallOpcode(uint functionIndex) {
            FunctionIndex = functionIndex;
        }

        public uint FunctionIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"call {FunctionIndex}";

    }
}
