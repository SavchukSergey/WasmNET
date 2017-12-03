namespace WasmNet.Opcodes {
    public abstract class I32UnaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var value = state.PopUI32();
            var res = Compare(value);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(uint value);

    }
}
