using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class I64Load32UOpcode : MemoryAccessOpcode {

        public I64Load32UOpcode(WasmMemoryImmediate immediate) : base(immediate) {
        }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt32(adr, Immediate);
            state.PushUI32(val);
        }

        public override string ToString() => $"i64.load32_u {Immediate}";

    }
}
