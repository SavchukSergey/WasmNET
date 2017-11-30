using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ConversionNode : BaseNode {

        public BaseNode Expression { get; set; }

        protected ConversionNode(BaseNode expression) {
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

        protected abstract WasmType OperandType { get; }

        protected abstract string NodeName { get; }

    }
}
