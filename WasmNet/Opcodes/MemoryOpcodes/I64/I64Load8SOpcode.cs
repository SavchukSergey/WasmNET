using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Load8SOpcode : MemoryAccessOpcode {

        public I64Load8SOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt8(adr, Immediate);
            state.PushSI64(val);
        }

        public override string ToString() => $"i64.load8_s {Immediate}";

    }
}
