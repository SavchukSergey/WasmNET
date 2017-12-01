using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrIfNode : ExecutableNode {

        public ExecutableNode Condition { get; }

        public Label Target { get; }

        public BrIfNode(ExecutableNode condition, Label target) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 operand");
            Condition = condition;
            Target = target;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(br_if ${Target.Name}");
            writer.Indent();
            Condition?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
