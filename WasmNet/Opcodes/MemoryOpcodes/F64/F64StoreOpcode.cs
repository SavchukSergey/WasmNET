namespace WasmNet.Opcodes {
    public class F64StoreOpcode : MemoryStoreOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopF64();
            var adr = state.PopUI32();
            state.Memory.WriteFloat64(adr, Immediate, val);
        }

        public override string ToString() => $"f64.store {Immediate}";

    }
}
