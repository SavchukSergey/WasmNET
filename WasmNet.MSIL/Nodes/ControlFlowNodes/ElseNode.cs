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
            writer.EnsureNewLine();
            writer.OpenNode("else");
            writer.WriteValueOrVoid(ResultType);
            writer.WriteLabelName(Nodes.Label);
            Nodes.ToString(writer);
            writer.EnsureNewLine();
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
