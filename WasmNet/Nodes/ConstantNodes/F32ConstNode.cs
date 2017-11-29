using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32ConstNode : BaseNode {

        public F32ConstNode(int value) {
            Value = value;
        }

        public float Value { get; set; }

        public override WasmType ResultType => WasmType.F32;

        public override void ToString(NodeWriter writer) {
            writer.Write(Value);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(f32.const {Value})");
        }

    }
}