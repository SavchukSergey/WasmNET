using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32TruncUF64Node : ConversionNode {

        public I32TruncUF64Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.F64;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.trunc_u/f64";

    }
}