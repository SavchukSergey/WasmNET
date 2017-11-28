namespace WasmNet.Nodes.ComparisionNodes {
    public abstract class BinaryComparisionNode : BaseNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public BinaryComparisionNode(BaseNode left, BaseNode right) {
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Left}) ??? ({Right})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Left.ToSExpressionString(writer);
            Right.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract string NodeName { get; }

    }
}
