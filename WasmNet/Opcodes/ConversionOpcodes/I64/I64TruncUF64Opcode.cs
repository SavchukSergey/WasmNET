namespace WasmNet.Opcodes {
    public class I64TruncUF64Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushUI64((ulong)arg);
        }

        public override string ToString() => "i64.trunc_u/f64";

    }
}
