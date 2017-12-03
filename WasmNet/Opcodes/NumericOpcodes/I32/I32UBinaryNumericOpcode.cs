namespace WasmNet.Opcodes {
    public abstract class I32UBinaryNumericOpcode : BaseOpcode {

        public sealed override void Execute(WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            var res = Execute(left, right);
            state.PushUI32(res);
        }

        protected abstract uint Execute(uint left, uint right);

    }
}
