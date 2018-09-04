using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64PromoteF32Node : ConversionNode {

        public F64PromoteF32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.F32;

        protected override string NodeName => "f64.demote/f32";

    }
}