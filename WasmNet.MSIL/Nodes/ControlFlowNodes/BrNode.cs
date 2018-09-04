using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrNode : ExecutableNode {

        public Label Target { get; }

        public BrNode(Label target) {
            Target = target;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("br");
            writer.WriteLabelName(Target);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
