namespace WasmNet.Opcodes {
    public class GrowMemoryOpcode : BaseOpcode {

        public byte Reserved { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI32();
            state.PushUI32(state.Memory.Resize(val));
        }

        public override string ToString() => "grow_memory";

    }
}
