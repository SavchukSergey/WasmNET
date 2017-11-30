using WasmNet.Data;

namespace WasmNet.Nodes {
    public class SelectNode : ExecutableNode {

        public ExecutableNode Condition { get; }

        public ExecutableNode First { get; }

        public ExecutableNode Second { get; }

        public SelectNode(ExecutableNode condition, ExecutableNode first, ExecutableNode second) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 condition");
            if (first.ResultType != second.ResultType) throw new WasmNodeException($"first and second argument must be of the same type");
            Condition = condition;
            First = first;
            Second = second;
        }

        public override WasmType ResultType => First.ResultType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine("(select");
            writer.Indent();
            Condition.ToString(writer);
            First.ToString(writer);
            Second.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}