namespace WasmNet.Opcodes {
    public class GlobalGetOpcode : BaseOpcode {

        public GlobalGetOpcode(uint globalIndex) {
            GlobalIndex = globalIndex;
        }
        
        public uint GlobalIndex { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"global.get {GlobalIndex}";

    }
}
