using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ExtendSI32Node : ConversionNode {

        public I64ExtendSI32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.I64;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i64.extend_s/i32";

    }
}