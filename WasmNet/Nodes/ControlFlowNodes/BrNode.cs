using System;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrNode : ExecutableNode {

        public BlockNode UnreachableNodes { get; } = new BlockNode(WasmType.BlockType);

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br 0)");
        }

    }
}
