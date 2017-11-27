namespace WasmNet.Nodes {
    public class IfNode : BaseNode {

        public IfNode(BaseNode condition, BlockNode thenNode, BlockNode elseNode) {
            Condition = condition;
            Then = thenNode;
            Else = elseNode;
        }

        public BaseNode Condition { get; set; }

        public BlockNode Then { get; set; }

        public BlockNode Else { get; set; }

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

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(if ");
            writer.Indent();
            Condition.ToSExpressionString(writer);
            Then.ToSExpressionString(writer);
            Else?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
