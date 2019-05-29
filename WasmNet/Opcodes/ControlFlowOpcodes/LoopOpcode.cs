using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class LoopOpcode : BaseOpcode {

        public LoopOpcode(WasmBlockType signature) {
            Signature = signature;
        }

        public WasmBlockType Signature { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"loop {Format(Signature)}";

    }
}
