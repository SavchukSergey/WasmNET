namespace WasmNet.Nodes {
    public class I32WrapI64Node : BaseNode {

        public BaseNode Operand { get; set; }

        public I32WrapI64Node(BaseNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i32.wrap/i32");
            writer.Indent();
            Operand.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}