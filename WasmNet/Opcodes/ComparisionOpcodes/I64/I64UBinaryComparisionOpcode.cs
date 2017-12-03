namespace WasmNet.Opcodes {
    public abstract class I64UBinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(ulong left, ulong right);

    }
}
