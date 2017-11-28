namespace WasmNet.Nodes {
    public class I64EqzNode : BaseNode {

        public I64EqzNode(BaseNode expr) {
            Expression = expr;
        }

        public BaseNode Expression { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression} == 0)");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i64.eqz");
            writer.Indent();
            Expression.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
