using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class UnaryNumericNode : BaseNode {

        public BaseNode Expression { get; set; }

        protected UnaryNumericNode(BaseNode expr) {
            //todo: move to setters? or readonly? check null
            if (expr.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} operand");
            Expression = expr;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression})");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Expression.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract string NodeName { get; }

        public WasmType OperandType => ResultType;

    }
}
