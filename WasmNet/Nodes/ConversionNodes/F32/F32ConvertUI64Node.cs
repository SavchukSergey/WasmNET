using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32ConvertUI64Node : ConversionNode {

        public F32ConvertUI64Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "f32.convert_u/i64";

    }
}