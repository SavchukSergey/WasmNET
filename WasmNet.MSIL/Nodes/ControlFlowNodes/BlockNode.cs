using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BlockNode : ExecutableNode {

        public NodesList Nodes { get; }

        public BlockNode(WasmType signature) {
            Nodes = new NodesList(signature);
        }

        public override WasmType ResultType => Nodes.Signature;

        public WasmType ActualResultType => Nodes.ActualResultType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("block");
            writer.WriteValueOrVoid(ResultType);
            writer.WriteLabelName(Nodes.Label);
            writer.EnsureNewLine();
            Nodes.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
