namespace WasmNet.Opcodes {
    public class I64Load16SOpcode : MemoryAccessOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt16(adr, Immediate);
            state.PushSI64(val);
        }

        public override string ToString() => $"i64.load16_s {Immediate}";

    }
}
