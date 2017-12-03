namespace WasmNet.Opcodes {
    public abstract class I64SBinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            var res = Execute(left, right);
            state.PushSI64(res);
        }

        protected abstract long Execute(long left, long right);

    }
}
