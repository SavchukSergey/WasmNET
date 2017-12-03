namespace WasmNet.Opcodes {
    public abstract class F32UnaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushF32(Execute(arg));
        }

        protected abstract float Execute(float arg);

    }
}
