using WasmNet.Data;

namespace WasmNet.Nodes {
    public class DropNode : BaseNode {

        public BaseNode Operand { get; set; }

        public DropNode(BaseNode operand) {
            Operand = operand;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(drop");
            writer.Indent();
            Operand.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}