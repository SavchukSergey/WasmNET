using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32ConstNode : ExecutableNode {

        public F32ConstNode(float value) {
            Value = value;
        }

        public float Value { get; set; }

        public override WasmType ResultType => WasmType.F32;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(f32.const {Value})");
        }

    }
}