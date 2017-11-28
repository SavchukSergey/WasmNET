using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ConstNode : BaseNode {

        public I64ConstNode(long value) {
            Value = value;
        }

        public long Value { get; set; }

        public override WasmType ResultType => WasmType.I64;

        public override void ToString(NodeWriter writer) {
            writer.Write(Value);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i64.const {Value})");
        }

    }
}