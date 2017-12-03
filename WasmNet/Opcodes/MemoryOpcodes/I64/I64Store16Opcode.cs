namespace WasmNet.Opcodes {
    public class I64Store16Opcode : MemoryStoreOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt16(adr, Immediate, (ushort)val);
        }

        public override string ToString() => $"i64.store16 {Immediate}";

    }
}
