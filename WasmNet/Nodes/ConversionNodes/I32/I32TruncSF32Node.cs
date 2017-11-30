using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32TruncSF32Node : ConversionNode {

        public I32TruncSF32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.trunc_s/f32";

    }
}