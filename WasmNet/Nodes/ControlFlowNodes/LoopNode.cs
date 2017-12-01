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
            if (!string.IsNullOrWhiteSpace(Nodes.Label.Name)) {
                writer.EnsureSpace();
                writer.Write($"${Nodes.Label.Name}");
            }

            writer.EnsureSpace();
            writer.Write($"{ConvertType(Nodes.Signature)}");

            writer.EnsureNewLine();
            Nodes.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
