namespace WasmNet.Nodes {
    public class AddNode : BaseNode {

        public BaseNode Left { get; set; }

        public BaseNode Right { get; set; }

        public AddNode(BaseNode left, BaseNode right) {
            Left = left;
            Right = right;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Left}) + ({Right})");
        }

    }
}