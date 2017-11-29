namespace WasmNet.Nodes {
    public abstract class BinaryComparisionNode : ComparisionNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public BinaryComparisionNode(BaseNode left, BaseNode right) {
            //todo: move to setters? or readonly? check null
            if (left.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} left operand");
            if (right.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} right operand");
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

    }
}
