namespace WasmNet.Opcodes {
    public class I32TruncF64UOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "i32.trunc_f64_u";

    }
}
