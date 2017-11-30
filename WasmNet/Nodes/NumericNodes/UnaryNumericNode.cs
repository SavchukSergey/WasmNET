using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class UnaryNumericNode : ExecutableNode {

        public ExecutableNode Expression { get; }

        protected UnaryNumericNode(ExecutableNode expr) {
            if (expr.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} operand");
            Expression = expr;
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Expression.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract string NodeName { get; }

        public WasmType OperandType => ResultType;

    }
}
