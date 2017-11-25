namespace WasmNet.Opcodes {
    public class GetGlobalOpcode : BaseOpcode {

        public uint GlobalIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"get_global {GlobalIndex}";

    }
}
