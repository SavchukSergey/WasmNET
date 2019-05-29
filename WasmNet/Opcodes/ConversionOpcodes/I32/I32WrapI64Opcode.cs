namespace WasmNet.Opcodes {
    public class I32WrapI64Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopUI64();
            state.PushUI32((uint)arg);
        }

        public override string ToString() => "i32.wrap_i64";

    }
}
