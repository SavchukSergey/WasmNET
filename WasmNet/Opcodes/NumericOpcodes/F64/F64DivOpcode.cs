namespace WasmNet.Opcodes {
    public class F64DivOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(left / right);
        }

        public override string ToString() => "f64.div";

    }
}
