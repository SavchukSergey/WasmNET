namespace WasmNet.Opcodes {
    public class LocalSetOpcode : BaseOpcode {

        public LocalSetOpcode(uint localIndex) {
            LocalIndex = localIndex;
        }

        public uint LocalIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"local.set {LocalIndex}";

    }
}
