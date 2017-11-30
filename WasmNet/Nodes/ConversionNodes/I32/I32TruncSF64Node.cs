using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32TruncSF64Node : ConversionNode {

        public I32TruncSF64Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.trunc_s/f64";

    }
}