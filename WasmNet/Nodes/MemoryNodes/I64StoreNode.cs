using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64StoreNode : MemoryAccessNode {

        public BaseNode Value { get; set; }

        public I64StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address) {
            Value = Value;
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i64.store{FormatImmediate()}");
            writer.Indent();
            Address?.ToSExpressionString(writer);
            Value?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();
    }
}