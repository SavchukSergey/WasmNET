namespace WasmNet.Opcodes {
    public abstract class I32UBinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(uint left, uint right);

    }
}
