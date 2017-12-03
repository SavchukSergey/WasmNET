using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GlobalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; }

        public bool Mutable { get; }

        public NodesList Init { get; }

        public GlobalNode(WasmType type, bool mutable) {
            AssertValueType(type);
            Type = type;
            Init = new NodesList(type);
            Mutable = mutable;
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
            writer.WriteValue(Type);
            writer.Write(")");

            if (Init != null && !Init.Empty) {
                writer.EnsureNewLine();
                Init.ToString(writer);
                writer.EnsureNewLine();
            }

            writer.CloseNode();
        }

    }
}
