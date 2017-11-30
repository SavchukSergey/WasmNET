using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ConvertUI64Node : ConversionNode {

        public F64ConvertUI64Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "f64.convert_u/i64";

    }
}