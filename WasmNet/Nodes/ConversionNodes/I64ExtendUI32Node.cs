namespace WasmNet.Nodes {
    public class I64ExtendUI32Node : BaseNode {

        public BaseNode Operand { get; set; }

        public I64ExtendUI32Node(BaseNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"(ulong)({Operand})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
        }

    }
}