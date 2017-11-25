namespace WasmNet.Opcodes {
    public class TeeLocalOpcode : BaseOpcode {

        public uint LocalIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"tee_local {LocalIndex}";

    }
}
