using System;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrNode : BaseNode {

        public BlockNode UnreachableNodes { get; } = new BlockNode();

        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br 0)");
        }

    }
}
