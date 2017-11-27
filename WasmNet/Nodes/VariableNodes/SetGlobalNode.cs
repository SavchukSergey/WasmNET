namespace WasmNet.Nodes {
    public class SetGlobalNode : BaseNode {

        public SetGlobalNode(GlobalNode variable, BaseNode value) {
            Variable = variable;
            Value = value;
        }

        public GlobalNode Variable { get; set; }

        public BaseNode Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Variable.Name} = ");
            Value.ToString(writer);
            writer.Write(";");
            writer.EndLine();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(set_global ${Variable.Name}");
            writer.Indent();
            Value.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}