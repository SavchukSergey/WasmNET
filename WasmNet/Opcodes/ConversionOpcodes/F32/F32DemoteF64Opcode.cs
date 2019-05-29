namespace WasmNet.Opcodes {
    public class F32DemoteF64Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushF32((float)arg);
        }

        public override string ToString() => "f32.demote_f64";

    }
}
