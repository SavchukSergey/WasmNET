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

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}");
            writer.Indent();
            Left.ToString(writer);
            Right.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        protected abstract string NodeName { get; }

        public WasmType OperandType => ResultType;

    }
}
