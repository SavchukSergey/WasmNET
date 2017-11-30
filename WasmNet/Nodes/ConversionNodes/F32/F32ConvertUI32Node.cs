using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32ConvertUI32Node : ConversionNode {

        public F32ConvertUI32Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "f32.convert_u/i32";

    }
}