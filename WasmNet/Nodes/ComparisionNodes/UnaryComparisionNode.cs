namespace WasmNet.Nodes {
    public abstract class UnaryComparisionNode : ComparisionNode {

        public ExecutableNode Expression { get; }

        protected UnaryComparisionNode(ExecutableNode expression) {
            if (expression.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} operand");
            Expression = expression;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode(NodeName);
            writer.EnsureSpace();
            Expression.ToString(writer);
            writer.CloseNode();
        }

    }
}
