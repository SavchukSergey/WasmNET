namespace WasmNet.Opcodes {
    public class SetGlobalOpcode : BaseOpcode {

        public uint GlobalIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"set_global {GlobalIndex}";

    }
}
