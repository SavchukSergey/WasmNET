namespace WasmNet.Nodes {
    public class LoopNode : BaseNode {

        public BlockNode Block { get; } = new BlockNode();

        public override void ToString(NodeWriter writer) {
            throw new System.NotImplementedException();
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(loop");
            writer.Indent();
            foreach (var node in Block.Nodes) {
                node.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
