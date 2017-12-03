namespace WasmNet.Opcodes {
    public class F64ConvertUI32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var value = state.PopUI32();
            state.PushF64(value);
        }

        public override string ToString() => "f64.convert_u/i32";

    }
}
