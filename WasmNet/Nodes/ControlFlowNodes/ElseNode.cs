using WasmNet.Data;

namespace WasmNet.Nodes {
    public class ElseNode : ExecutableNode {

        public NodesList Nodes { get; }

        public ElseNode(NodesList nodes) {
            Nodes = nodes;
        }

        public override WasmType ResultType => Nodes.Signature;

        public WasmType ActualResultType => Nodes.ActualResultType;

        public override void ToString(NodeWriter writer) {
            writer.NewLine();
            writer.OpenNode("else");
            if (ResultType != WasmType.BlockType) {
                writer.Write(" ");
                writer.Write(ConvertType(ResultType));
            }
            if (!string.IsNullOrWhiteSpace(Nodes.Label.Name)) {
                writer.Write("$");
                writer.Write(Nodes.Label.Name);
            }
            writer.NewLine();
            Nodes.ToString(writer);
            writer.CloseNode();
            writer.NewLine();
        }

    }
}
