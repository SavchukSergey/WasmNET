using WasmNet.Data;

namespace WasmNet.Nodes {
    public class NopNode : ExecutableNode {

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine("(nop)");
        }

    }
}
