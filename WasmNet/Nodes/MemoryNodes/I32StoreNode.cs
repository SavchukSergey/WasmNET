using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32StoreNode : MemoryAccessNode {

        public BaseNode Value { get; set; }

        public I32StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address) {
            Value = Value;
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i32.store{FormatImmediate()}");
            writer.Indent();
            Address?.ToSExpressionString(writer);
            Value?.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();
    }
}