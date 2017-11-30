using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32ConstNode : ExecutableNode {

        public I32ConstNode(int value) {
            Value = value;
        }

        public int Value { get; set; }

        public override WasmType ResultType => WasmType.I32;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(i32.const {Value})");
        }

    }
}