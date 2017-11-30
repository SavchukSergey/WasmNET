using WasmNet.Data;

namespace WasmNet.Nodes {
    public class CurrentMemoryNode : ExecutableNode {

        public override WasmType ResultType => WasmType.I32;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(current_memory)");
        }

    }
}
