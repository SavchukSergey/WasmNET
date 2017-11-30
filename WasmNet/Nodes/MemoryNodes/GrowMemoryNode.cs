using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GrowMemoryNode : ExecutableNode {

        public ExecutableNode Expression { get; }

        public GrowMemoryNode(ExecutableNode expression) {
            if (expression.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 operand");
            Expression = expression;
        }

        public override WasmType ResultType => WasmType.I32;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(grow_memory");
            writer.Indent();
            Expression.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
