namespace WasmNet.Nodes {
    public class ImportNode : DeclarationNode {

        public string Module { get; set; }

        public string Field { get; set; }

        public BaseNode Node { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(import \"{Module}\" \"{Field}\" ");
            writer.Indent();
            Node?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
