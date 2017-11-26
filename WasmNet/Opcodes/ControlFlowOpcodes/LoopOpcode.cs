using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class LoopOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"loop {Signature}";

    }
}
