namespace WasmNet.Opcodes {
    public class I64TruncF32UOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "i32.trunc_f32_u";

    }
}
