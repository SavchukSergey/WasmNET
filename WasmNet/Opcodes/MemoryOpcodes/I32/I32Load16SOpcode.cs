using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I32Load16SOpcode : MemoryAccessOpcode {

        public I32Load16SOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt16(adr, Immediate);
            state.PushSI32(val);
        }

        public override string ToString() => $"i32.load16_s {Immediate}";

    }
}
