using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ReinterpretationNode : ExecutableNode {

        public ExecutableNode Expression { get; }

        protected ReinterpretationNode(ExecutableNode expression) {
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

        protected abstract WasmType OperandType { get; }

        protected abstract string NodeName { get; }

    }
}
