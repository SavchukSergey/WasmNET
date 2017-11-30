using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32DemoteF64Node : ConversionNode {

        public F32DemoteF64Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.F64;

        protected override string NodeName => "f32.demote/f64";

    }
}