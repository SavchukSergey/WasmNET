namespace WasmNet.Opcodes {
    public abstract class I32SBinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            var res = Execute(left, right);
            state.PushSI32(res);
        }

        protected abstract int Execute(int left, int right);

    }
}
