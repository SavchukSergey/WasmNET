namespace WasmNet.Opcodes {
    public class CurrentMemoryOpcode : BaseOpcode {

        public byte Reserved { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

    }
}
