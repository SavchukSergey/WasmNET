namespace WasmNet.Nodes {
    public class ReturnNode : BaseNode {

        public ReturnNode() {
        }

        public ReturnNode(BaseNode expr) {
            Expression = expr;
        }

        public BaseNode Expression { get; set; }

        public override void ToString(NodeWriter writer) {
            if (Expression == null) {
                writer.WriteLine("return;");
            } else {
                writer.WriteLine($"return {Expression};");
            }
        }

        public override void ToSExpressionString(NodeWriter writer) {
            if (Expression == null) {
                writer.WriteLine("(return)");
            } else {
                writer.WriteLine("(return");
                writer.Indent();
                Expression.ToSExpressionString(writer);
                writer.Unindent();
                writer.WriteLine(")");
            }
        }

    }
}