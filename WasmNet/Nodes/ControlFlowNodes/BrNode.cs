using System;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrNode : BaseNode {

        public BlockNode Block { get; } = new BlockNode(WasmType.I32);

        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br 0");
            writer.Indent();
            foreach(var node in Block.Nodes) {
                node.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
