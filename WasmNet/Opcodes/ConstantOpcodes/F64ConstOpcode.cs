namespace WasmNet.Opcodes {
    public class F64ConstOpcode : BaseOpcode {

        public double Value { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"f64.const {Value}";

    }
}
