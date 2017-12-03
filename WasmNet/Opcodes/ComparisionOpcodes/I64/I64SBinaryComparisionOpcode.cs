namespace WasmNet.Opcodes {
    public abstract class I64SBinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(long left, long right);

    }
}
