using WasmNet.Data;

namespace WasmNet.Nodes {
    public class DropNode : ExecutableNode {

        public ExecutableNode Operand { get; set; }

        public DropNode(ExecutableNode operand) {
            Operand = operand;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine("(drop");
            writer.Indent();
            Operand.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}