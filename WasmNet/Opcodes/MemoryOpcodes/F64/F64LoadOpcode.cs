namespace WasmNet.Opcodes {
    public class F64LoadOpcode : MemoryAccessOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadFloat64(adr, Immediate);
            state.PushF64(val);
        }

        public override string ToString() => $"f64.load {Immediate}";

    }
}
