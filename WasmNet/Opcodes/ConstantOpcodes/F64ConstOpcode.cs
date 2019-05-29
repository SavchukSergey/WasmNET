using System.Globalization;

namespace WasmNet.Opcodes {
    public class F64ConstOpcode : BaseOpcode {

        public F64ConstOpcode(double value) {
            Value = value;
        }

        public double Value { get; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"f64.const {Value.ToString(CultureInfo.InvariantCulture)}";

    }
}
