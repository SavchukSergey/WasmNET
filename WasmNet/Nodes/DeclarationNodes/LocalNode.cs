using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LocalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; private set; }

        public LocalNode(WasmType type) {
            AssertValueType(type);
            Type = type;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("local");
            writer.EnsureSpace();
            writer.Write($"${Name}");
            writer.EnsureSpace();
            writer.Write(ConvertValueType(Type));
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
