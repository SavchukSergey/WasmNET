namespace WasmNet.Opcodes {
    public class MemoryGrowOpcode : BaseOpcode {

        public MemoryGrowOpcode(byte reserved) {
            Reserved = reserved;
        }

        public byte Reserved { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI32();
            state.PushUI32(state.Memory.Resize(val));
        }

        public override string ToString() => "memory.grow";

    }
}
