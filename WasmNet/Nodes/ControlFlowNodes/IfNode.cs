namespace WasmNet.Nodes {
    public class IfNode : BaseNode {

        public IfNode(BaseNode condition, BaseNode thenNode, BaseNode elseNode) {
            Condition = condition;
            Then = thenNode;
            Else = elseNode;
        }

        public BaseNode Condition { get; set; }

        public BaseNode Then { get; set; }

        public BaseNode Else { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"if ({Condition}) {{");

            writer.Indent();
            if (Then != null) {
                Then.ToString(writer);
            }
            writer.Unindent();

            if (Else != null) {
                writer.WriteLine("} else {");
                writer.Indent();
                Else.ToString(writer);
                writer.Unindent();
                writer.WriteLine("}");
            } else {
                writer.WriteLine("}");
            }
        }

    }
}
