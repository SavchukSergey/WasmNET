namespace WasmNet.Opcodes {
    public abstract class F32BinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(float left, float right);

    }
}
