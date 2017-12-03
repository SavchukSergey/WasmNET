namespace WasmNet.Opcodes {
    public abstract class I64UnaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var value = state.PopUI64();
            var res = Compare(value);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(ulong value);

    }
}
