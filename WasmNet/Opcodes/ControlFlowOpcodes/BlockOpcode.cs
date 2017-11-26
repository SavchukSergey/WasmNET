using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class BlockOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"block {Signature}";

    }
}
