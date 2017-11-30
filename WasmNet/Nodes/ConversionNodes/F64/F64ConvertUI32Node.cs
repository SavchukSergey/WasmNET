using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ConvertUI32Node : ConversionNode {

        public F64ConvertUI32Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "f64.convert_u/i32";

    }
}