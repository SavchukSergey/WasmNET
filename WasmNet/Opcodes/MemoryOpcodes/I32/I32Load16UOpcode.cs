using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Load16UOpcode : MemoryAccessOpcode {

        public I32Load16UOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i32.load16_u {Immediate}";

    }
}
