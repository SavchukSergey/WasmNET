using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ConstNode : BaseNode {

        public F64ConstNode(int value) {
            Value = value;
        }

        public double Value { get; set; }

        public override WasmType ResultType => WasmType.F64;

        public override void ToString(NodeWriter writer) {
            writer.Write(Value);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(f64.const {Value})");
        }

    }
}