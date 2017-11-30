using WasmNet.Data;

namespace WasmNet.Nodes {
    public class LoopNode : ExecutableNode {

        public BlockNode Block { get; }

        public LoopNode(WasmType signature) {
            Block = new BlockNode(signature);
        }

        public override WasmType ResultType => Block.ResultType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(loop {ConvertType(Block.ResultType)}");
            writer.Indent();
            foreach (var node in Block.Nodes) {
                node.ToString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
