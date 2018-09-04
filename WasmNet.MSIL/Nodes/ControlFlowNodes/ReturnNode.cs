using WasmNet.Data;

namespace WasmNet.Nodes {
    public class ReturnNode : ExecutableNode {

        public ExecutableNode Expression { get; }

        public ReturnNode() {
        }

        public ReturnNode(ExecutableNode expr) {
            AssertValueType(expr.ResultType);
            Expression = expr;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("return");
            if (Expression != null) {
                writer.EnsureSpace();
                Expression.ToString(writer);
            }
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}