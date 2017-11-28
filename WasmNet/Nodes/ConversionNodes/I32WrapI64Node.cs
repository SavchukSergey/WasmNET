using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32WrapI64Node : BaseNode {

        public BaseNode Operand { get; set; }

        public I32WrapI64Node(BaseNode operand) {
            if (operand.ResultType != WasmType.I64) throw new WasmNodeException($"expected i64 operand");
            Operand = operand;
        }

        public override WasmType ResultType => WasmType.I32;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(i32.wrap/i64");
            writer.Indent();
            Operand.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}