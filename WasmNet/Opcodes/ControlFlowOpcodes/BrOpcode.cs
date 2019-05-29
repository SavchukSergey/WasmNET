namespace WasmNet.Opcodes {
    public class BrOpcode : BaseOpcode {

        public BrOpcode(uint relativeDepth) {
            RelativeDepth = relativeDepth;
        }

        public uint RelativeDepth { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"br {RelativeDepth}";

    }
}
