namespace WasmNet.Nodes {
    public class I32EqzNode : BaseNode {

        public I32EqzNode(BaseNode expr) {
            Expression = expr;
        }

        public BaseNode Expression { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression} == 0)");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i32.eqz");
            writer.Indent();
            Expression.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
