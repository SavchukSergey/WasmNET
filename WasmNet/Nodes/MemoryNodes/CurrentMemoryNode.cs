namespace WasmNet.Nodes {
    public class CurrentMemoryNode : BaseNode {

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(current_memory)");
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

    }
}
