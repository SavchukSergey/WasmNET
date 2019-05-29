namespace WasmNet.Opcodes {
    public class F64PromoteF32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushF64(arg);
        }

        public override string ToString() => "f64.promote_f32";

    }
}
