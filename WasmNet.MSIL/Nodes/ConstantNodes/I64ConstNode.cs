using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ConstNode : ExecutableNode {

        public I64ConstNode(long value) {
            Value = value;
        }

        public long Value { get; set; }

        public override WasmType ResultType => WasmType.I64;

        public override void ToString(NodeWriter writer) {
            writer.OpenNode($"i64.const");
            writer.EnsureSpace();
            writer.Write(Value);
            writer.CloseNode();
        }

    }
}