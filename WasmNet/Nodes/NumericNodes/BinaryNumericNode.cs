using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class BinaryNumericNode : ExecutableNode {

        public ExecutableNode Left { get; set; }

        public ExecutableNode Right { get; set; }

        protected BinaryNumericNode(ExecutableNode left, ExecutableNode right) {
            if (left.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} left operand");
            if (right.ResultType != OperandType) throw new WasmNodeException($"expected {OperandType} right operand");
            Left = left;
            Right = right;
        }

        public sealed override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode(NodeName);
            writer.EnsureSpace();
            Left.ToString(writer);
            writer.EnsureSpace();
            Right.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

        protected abstract string NodeName { get; }

        public WasmType OperandType => ResultType;

    }
}
