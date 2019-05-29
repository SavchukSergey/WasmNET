using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Store8Opcode : MemoryStoreOpcode {

        public I32Store8Opcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"i32.store8 {Immediate}";

    }
}
