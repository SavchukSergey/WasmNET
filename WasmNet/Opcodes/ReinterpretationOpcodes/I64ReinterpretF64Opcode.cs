namespace WasmNet.Opcodes {
    public class I64ReinterpretF64Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "i64.reinterpret_f64";

    }
}
