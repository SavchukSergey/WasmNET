using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64StoreOpcode : MemoryStoreOpcode {

        public I64StoreOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt64(adr, Immediate, val);
        }

        public override string ToString() => $"i64.store {Immediate}";

    }
}
