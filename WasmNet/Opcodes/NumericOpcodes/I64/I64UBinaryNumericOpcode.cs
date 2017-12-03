namespace WasmNet.Opcodes {
    public abstract class I64UBinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            var res = Execute(left, right);
            state.PushUI64(res);
        }

        protected abstract ulong Execute(ulong left, ulong right);

    }
}
