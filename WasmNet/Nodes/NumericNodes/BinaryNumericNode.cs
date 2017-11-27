namespace WasmNet.Nodes {
    public abstract class BinaryNumericNode : BaseNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public BinaryNumericNode(BaseNode left, BaseNode right) {
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Left}) + ({Right})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i32.add");
            writer.Indent();
            Left.ToSExpressionString(writer);
            Right.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract string NodeName { get; }

    }
}
