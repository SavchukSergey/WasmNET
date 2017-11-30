using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryLoadNode : MemoryAccessNode {

        protected MemoryLoadNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public sealed override void ToString(NodeWriter writer) {
            writer.WriteLine($"({NodeName}{FormatImmediate()}");
            writer.Indent();
            Address.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
