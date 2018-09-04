using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ConversionNode : ExecutableNode {

        public ExecutableNode Expression { get; }

        protected ConversionNode(ExecutableNode expression) {
            if (expression.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} operand");
            Expression = expression;
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Expression.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract WasmType OperandType { get; }

        protected abstract string NodeName { get; }

    }
}
