using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Load16UOpcode : MemoryAccessOpcode {

        public I64Load16UOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt16(adr, Immediate);
            state.PushUI64(val);
        }

        public override string ToString() => $"i64.load16_u {Immediate}";

    }
}
