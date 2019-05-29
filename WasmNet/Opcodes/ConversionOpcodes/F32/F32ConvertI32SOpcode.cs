namespace WasmNet.Opcodes {
    public class F32ConvertI32SOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var value = state.PopSI32();
            state.PushF32(value);
        }

        public override string ToString() => "f32.convert_i32_s";

    }
}
