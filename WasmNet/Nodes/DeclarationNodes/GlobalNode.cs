using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GlobalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; private set; }

        public bool Mutable { get; set; }

        public NodesList Init { get; set; }

        public GlobalNode(WasmType type) {
            //todo: assert init block type
            AssertValueType(type);
            Type = type;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("global");
            writer.EnsureSpace();
            writer.Write($"${Name}");
            writer.EnsureSpace();

            writer.Write("(");
            if (Mutable) {
                writer.Write("mut ");
            }
            writer.Write(ConvertValueType(Type));
            writer.Write(")");

            if (Init != null) {
                writer.EnsureNewLine();
                Init.ToString(writer);
                writer.EnsureNewLine();
            }

            writer.CloseNode();
        }

    }
}
