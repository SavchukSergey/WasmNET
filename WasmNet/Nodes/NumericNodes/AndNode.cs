namespace WasmNet.Nodes {
    public class AndNode : BaseNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public AndNode(BaseNode left, BaseNode right) {
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Left}) & ({Right})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
        }

    }
}