namespace WasmNet.Nodes {
    public class TeeLocalNode : BaseNode {

        public TeeLocalNode(LocalNode variable, BaseNode value) {
            Variable = variable;
            Value = value;
        }

        public LocalNode Variable { get; set; }

        public BaseNode Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Variable.Name} = ");
            Value.ToString(writer);
            writer.Write(";");
            writer.EndLine();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(tee_local ${Variable.Name}");
            writer.Indent();
            Value.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}