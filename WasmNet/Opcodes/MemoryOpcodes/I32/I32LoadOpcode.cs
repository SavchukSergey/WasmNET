namespace WasmNet.Opcodes {
    public class I32LoadOpcode : MemoryAccessOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt32(adr, Immediate);
            state.PushUI32(val);
        }

        public override string ToString() => $"i32.load {Immediate}";

    }
}
