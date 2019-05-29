using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Store32Opcode : MemoryStoreOpcode {

        public I64Store32Opcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt32(adr, Immediate, (uint)val);
        }

        public override string ToString() => $"i64.store32 {Immediate}";

    }
}
