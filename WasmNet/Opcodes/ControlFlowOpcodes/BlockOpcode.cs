using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class BlockOpcode : BaseOpcode {

        public BlockOpcode(WasmBlockType signature) {
            Signature = signature;
        }

        public WasmBlockType Signature { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            state.PushLabel(Signature);
        }

        public override string ToString() => $"block {Format(Signature)}";

    }
}
