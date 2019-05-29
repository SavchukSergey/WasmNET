using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Store16Opcode : MemoryStoreOpcode {

        public I64Store16Opcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i64.store16 {Immediate}";

    }
}
