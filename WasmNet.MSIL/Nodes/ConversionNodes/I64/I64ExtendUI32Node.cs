using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ExtendUI32Node : ConversionNode {

        public I64ExtendUI32Node(ExecutableNode operand) : base(operand) {
        }

        public override WasmType ResultType => WasmType.I64;

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i64.extend_u/i32";

    }
}