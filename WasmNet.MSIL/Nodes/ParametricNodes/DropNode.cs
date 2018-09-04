using WasmNet.Data;

namespace WasmNet.Nodes {
    public class DropNode : ExecutableNode {

        public ExecutableNode Operand { get; }

        public DropNode(ExecutableNode operand) {
            Operand = operand;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("drop");
            writer.EnsureNewLine();
            Operand.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}