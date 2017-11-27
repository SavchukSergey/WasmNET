namespace WasmNet.Nodes {
    public class ImportNode : BaseNode {

        public string Module { get; set; }

        public string Field { get; set; }

        public BaseNode Node { get; set; }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(import \"{Module}\" \"{Field}\" ");
            writer.Indent();
            Node?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
