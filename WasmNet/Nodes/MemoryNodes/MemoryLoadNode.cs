using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryLoadNode : MemoryAccessNode {

        public MemoryLoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public sealed override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}{FormatImmediate()}");
            writer.Indent();
            Address.ToSExpressionString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
