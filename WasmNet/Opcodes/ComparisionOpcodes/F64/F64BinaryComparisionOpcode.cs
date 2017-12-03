namespace WasmNet.Opcodes {
    public abstract class F64BinaryComparisionOpcode : BinaryComparisionOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            var res = Compare(left, right);
            state.PushUI32(res ? 1u : 0u);
        }

        protected abstract bool Compare(double left, double right);

    }
}
