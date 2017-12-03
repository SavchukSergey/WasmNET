namespace WasmNet.Opcodes {
    public abstract class F64UnaryNumericOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushF64(Execute(arg));
        }

        protected abstract double Execute(double arg);

    }
}
