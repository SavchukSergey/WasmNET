namespace WasmNet.Nodes {
    public class SetLocalNode : BaseNode {

        public SetLocalNode(LocalVariable variable, BaseNode value) {
            Variable = variable;
            Value = value;
        }

        public LocalVariable Variable { get; set; }

        public BaseNode Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Variable.Name} = ");
            Value.ToString(writer);
            writer.Write(";");
            writer.EndLine();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(set_local ${Variable.Name}");
            writer.Indent();
            Value.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}