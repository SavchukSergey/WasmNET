using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Store16Opcode : MemoryStoreOpcode {

        public I32Store16Opcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i32.store16 {Immediate}";

    }
}
