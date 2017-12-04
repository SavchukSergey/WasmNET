namespace WasmNet.Opcodes {
    public class CallOpcode : BaseOpcode {

        public uint FunctionIndex { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"call {FunctionIndex}";

    }
}
