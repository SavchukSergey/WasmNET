using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64TruncSF32Node : ConversionNode {

        public I64TruncSF32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "i64.trunc_s/f32";

    }
}