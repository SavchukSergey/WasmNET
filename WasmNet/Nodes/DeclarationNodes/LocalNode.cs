using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LocalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; }

        public LocalNode(WasmType type) {
            AssertValueType(type);
            Type = type;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("local");
            writer.EnsureSpace();
            writer.WriteVariableName(this);
            writer.WriteValue(Type);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
