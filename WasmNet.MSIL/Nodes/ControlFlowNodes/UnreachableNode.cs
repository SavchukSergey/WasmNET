using WasmNet.Data;

namespace WasmNet.Nodes {
    public class UnreachableNode : ExecutableNode {

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine("(unreachable)");
        }

    }
}
