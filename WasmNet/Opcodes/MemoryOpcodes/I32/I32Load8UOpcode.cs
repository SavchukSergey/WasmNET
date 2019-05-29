using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Load8UOpcode : MemoryAccessOpcode {

        public I32Load8UOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i32.load8_u {Immediate}";

    }
}
