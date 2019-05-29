using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Load8UOpcode : MemoryAccessOpcode {

        public I64Load8UOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i64.load8_u {Immediate}";

    }
}
