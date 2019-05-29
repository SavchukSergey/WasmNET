namespace WasmNet.Opcodes {
    public class I64ExtendI32UOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopUI32();
            state.PushUI64(arg);
        }

        public override string ToString() => "i64.extend_i32_u";

    }
}
