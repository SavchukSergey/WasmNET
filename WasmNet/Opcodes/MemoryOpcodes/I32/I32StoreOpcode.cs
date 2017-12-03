namespace WasmNet.Opcodes {
    public class I32StoreOpcode : MemoryStoreOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI32();
            var adr = state.PopUI32();
            state.Memory.WriteUInt32(adr, Immediate, val);
        }

        public override string ToString() => $"i32.store {Immediate}";

    }
}
