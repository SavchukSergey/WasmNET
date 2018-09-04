using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class MemoryLoadNode : MemoryAccessNode {

        protected MemoryLoadNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public sealed override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode(NodeName);
            writer.Write(FormatImmediate());

            writer.EnsureNewLine();
            Address.ToString(writer);

            writer.EnsureNewLine();
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}
