namespace WasmNet.Opcodes {
    public class CallIndirectOpcode : BaseOpcode {

        public uint TypeIndex { get; set; }

        public uint Reserved { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"call_indirect {TypeIndex}";

    }
}
