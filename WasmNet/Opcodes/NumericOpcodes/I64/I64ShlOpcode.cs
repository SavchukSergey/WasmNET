namespace WasmNet.Opcodes {
    public class I64ShlOpcode : BaseNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "i64.shl";

    }
}
