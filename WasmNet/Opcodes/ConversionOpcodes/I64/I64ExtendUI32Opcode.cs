namespace WasmNet.Opcodes {
    public class I64ExtendUI32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopUI32();
            state.PushUI64(arg);
        }

        public override string ToString() => "i64.extend_u/i32";

    }
}
