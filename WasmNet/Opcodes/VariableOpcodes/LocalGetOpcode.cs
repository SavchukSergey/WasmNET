namespace WasmNet.Opcodes {
    public class LocalGetOpcode : BaseOpcode {

        public LocalGetOpcode(uint localIndex) {
            LocalIndex = localIndex;
        }

        public uint LocalIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"local.get {LocalIndex}";

    }
}
