namespace WasmNet.Nodes {
    public class ImportNode : DeclarationNode {

        public string Module { get; set; }

        public string Field { get; set; }

        public BaseNode Node { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("import");
            writer.Write($" \"{Module}\" \"{Field}\" ");
            Node?.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
