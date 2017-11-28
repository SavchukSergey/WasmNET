namespace WasmNet.Nodes {
    public class I64ExtendSI32Node : BaseNode {

        public BaseNode Operand { get; set; }

        public I64ExtendSI32Node(BaseNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i64.extend_s/i32");
            writer.Indent();
            Operand.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}