namespace WasmNet.Opcodes {
    public abstract class F64BinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            var res = Execute(left, right);
            state.PushF64(res);
        }

        protected abstract double Execute(double left, double right);

    }
}
