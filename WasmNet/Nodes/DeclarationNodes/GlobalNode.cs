using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GlobalNode : DeclarationNode {

        public string Name { get; set; }

        public WasmType Type { get; private set; }

        public bool Mutable { get; set; }

        public BlockNode Init { get; set; }

        public GlobalNode(WasmType type) {
            //todo: assert init block type
            AssertValueType(type);
            Type = type;
        }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"(global ${Name} ({(Mutable ? "mut " : "")}{ConvertValueType(Type)})");
            if (Init != null) {
                writer.EndLine();
                writer.Indent();
                Init.ToString(writer);
                writer.Unindent();
                writer.WriteLine(")");
            } else {
                writer.Write(")");
                writer.EndLine();
            }
        }

    }
}
