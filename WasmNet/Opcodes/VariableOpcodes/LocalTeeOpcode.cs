namespace WasmNet.Opcodes {
    public class LocalTeeOpcode : BaseOpcode {

        public LocalTeeOpcode(uint localIndex) {
            LocalIndex = localIndex;
        }

        public uint LocalIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"local.tee {LocalIndex}";

    }
}
