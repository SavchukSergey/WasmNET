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
            if (Expression == null) {
                writer.WriteLine("(return)");
            } else {
                writer.WriteLine("(return");
                writer.Indent();
                Expression.ToString(writer);
                writer.Unindent();
                writer.WriteLine(")");
            }
        }

    }
}