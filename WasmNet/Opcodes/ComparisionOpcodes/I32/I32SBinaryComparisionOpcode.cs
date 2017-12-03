namespace WasmNet.Opcodes {
    public abstract class I32SBinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(int left, int right);

    }
}
