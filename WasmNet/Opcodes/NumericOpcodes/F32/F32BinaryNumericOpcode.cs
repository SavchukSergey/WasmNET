namespace WasmNet.Opcodes {
    public abstract class F32BinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            var res = Execute(left, right);
            state.PushF64(res);
        }

        protected abstract double Execute(float left, float right);

    }
}
