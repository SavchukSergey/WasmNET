using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64LoadNode : MemoryAccessNode {

        public I64LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i64.load{FormatImmediate()}");
            writer.Indent();
            Address.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();
    }
}