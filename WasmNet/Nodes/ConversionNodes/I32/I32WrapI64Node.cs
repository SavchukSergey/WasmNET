using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32WrapI64Node : ConversionNode {

        public I32WrapI64Node(BaseNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.I32;

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "i32.wrap/i64";

    }
}