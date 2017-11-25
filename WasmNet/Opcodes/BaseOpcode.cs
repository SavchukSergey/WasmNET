namespace WasmNet.Opcodes {
    public abstract class BaseOpcode {

        public abstract TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg);

    }
}
