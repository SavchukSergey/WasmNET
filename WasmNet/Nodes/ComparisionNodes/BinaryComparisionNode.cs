namespace WasmNet.Nodes {
    public abstract class BinaryComparisionNode : ComparisionNode {

        public ExecutableNode Left { get; }

        public ExecutableNode Right { get; }

        protected BinaryComparisionNode(ExecutableNode left, ExecutableNode right) {
            if (left.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} left operand");
            if (right.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} right operand");
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode(NodeName);
            writer.EnsureSpace();
            Left.ToString(writer);
            writer.EnsureSpace();
            Right.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
