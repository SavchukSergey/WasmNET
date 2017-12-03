namespace WasmNet.Opcodes {
    public abstract class F32BinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            var res = Execute(left, right);
            state.PushF32(res);
        }

        protected abstract float Execute(float left, float right);

    }
}
