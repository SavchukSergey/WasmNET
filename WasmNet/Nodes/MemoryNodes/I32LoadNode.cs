using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32LoadNode : MemoryAccessNode {

        public I32LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(i32.load{FormatImmediate()}");
            writer.Indent();
            Address.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();
    }
}