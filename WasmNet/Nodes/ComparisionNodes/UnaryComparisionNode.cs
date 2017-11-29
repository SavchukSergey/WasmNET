namespace WasmNet.Nodes {
    public abstract class UnaryComparisionNode : ComparisionNode {

        public BaseNode Expression { get; set; }

        protected UnaryComparisionNode(BaseNode expression) {
            //todo: move to setters? or readonly? check null
            if (expression.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} operand");
            Expression = expression;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression}) ???");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Expression.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
