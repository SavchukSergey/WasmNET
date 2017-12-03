namespace WasmNet.Opcodes {
    public class F32LoadOpcode : MemoryAccessOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadFloat32(adr, Immediate);
            state.PushF32(val);
        }

        public override string ToString() => $"f32.load {Immediate}";

    }
}
