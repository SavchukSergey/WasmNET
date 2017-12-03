using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LoopNode : ExecutableNode {

        public NodesList Nodes { get; }

        public LoopNode(WasmType signature) {
            Nodes = new NodesList(signature);
        }

        public override WasmType ResultType => Nodes.Signature;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("loop");
            writer.WriteLabelName(Nodes.Label);

            writer.WriteValueOrVoid(ResultType);

            writer.EnsureNewLine();
            Nodes.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
