using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GrowMemoryNode : BaseNode {

        public BaseNode Expression { get; set; }

        public GrowMemoryNode(BaseNode expression) {
            //todo: move to setters? or readonly? check null
            if (expression.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 operand");
            Expression = expression;
        }

        public override WasmType ResultType => WasmType.I32;

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression}) ???");
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(grow_memory");
            writer.Indent();
            Expression.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
