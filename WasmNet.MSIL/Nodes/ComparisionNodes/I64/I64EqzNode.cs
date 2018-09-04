using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64EqzNode : UnaryComparisionNode {

        public I64EqzNode(ExecutableNode expr) : base(expr) {
        }

        protected override WasmType OperandType => WasmType.I64;

        protected override string NodeName => "i64.eqz";

    }
}
