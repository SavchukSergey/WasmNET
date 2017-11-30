using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32TruncUF32Node : ConversionNode {

        public I32TruncUF32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.trunc_u/f32";

    }
}