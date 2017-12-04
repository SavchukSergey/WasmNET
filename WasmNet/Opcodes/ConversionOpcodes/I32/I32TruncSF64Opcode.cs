namespace WasmNet.Opcodes {
    public class I32TruncSF64Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushSI32((int)arg);
        }

        public override string ToString() => "i32.trunc_s/f64";

    }
}
