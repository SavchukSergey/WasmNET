using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ConvertSI64Node : ConversionNode {

        public F64ConvertSI64Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "f64.convert_s/i64";

    }
}