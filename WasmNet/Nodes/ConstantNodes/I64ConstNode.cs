namespace WasmNet.Nodes {
    public class I64ConstNode : BaseNode {

        public I64ConstNode(long value) {
            Value = value;
        }

        public long Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.Write(Value);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i64.const {Value})");
        }

    }
}