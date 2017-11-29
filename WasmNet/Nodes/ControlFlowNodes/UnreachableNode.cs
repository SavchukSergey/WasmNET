namespace WasmNet.Nodes {
    public class UnreachableNode : BaseNode {

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(unreachable)");
        }

    }
}
