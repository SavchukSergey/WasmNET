using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ExtendUI32Node : BaseNode {

        public BaseNode Operand { get; set; }

        public I64ExtendUI32Node(BaseNode operand) {
            Operand = operand;
        }

        public override WasmType ResultType => WasmType.I64;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i64.extend_u/i32");
            writer.Indent();
            Operand.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}