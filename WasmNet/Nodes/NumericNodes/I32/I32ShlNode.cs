namespace WasmNet.Nodes {
    public class I32ShlNode : BaseNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public I32ShlNode(BaseNode left, BaseNode right) {
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Left}) << ({Right})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i32.shl");
            writer.Indent();
            Left.ToSExpressionString(writer);
            Right.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
