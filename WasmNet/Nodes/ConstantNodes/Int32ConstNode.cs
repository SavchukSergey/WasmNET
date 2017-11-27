namespace WasmNet.Nodes {
    public class Int32ConstNode : BaseNode {

        public Int32ConstNode(int value) {
            Value = value;
        }

        public int Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.Write(Value);
        }

        public override void ToSExpressionString(NodeWriter writer) {
        }

    }
}