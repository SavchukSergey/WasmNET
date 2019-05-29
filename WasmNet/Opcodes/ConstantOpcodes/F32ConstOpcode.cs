using System.Globalization;

namespace WasmNet.Opcodes {
    public class F32ConstOpcode : BaseOpcode {

        public F32ConstOpcode(float value) {
            Value = value;
        }

        public float Value { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            state.PushF32(Value);
        }

        public override string ToString() => $"f32.const {Value.ToString(CultureInfo.InvariantCulture)}";

    }
}
