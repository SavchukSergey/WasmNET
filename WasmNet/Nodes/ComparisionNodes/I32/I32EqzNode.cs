using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32EqzNode : UnaryComparisionNode {

        public I32EqzNode(BaseNode expr) : base(expr) {
        }

        protected override WasmType OperandType => WasmType.I32;

        protected override string NodeName => "i32.eqz";

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression} == 0)");
        }

    }
}
