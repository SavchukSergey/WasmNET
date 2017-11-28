using System;

namespace WasmNet.Nodes {
    public class BrIfNode : BaseNode {

        public BaseNode Condition { get; set; }

        public BlockNode Block { get; } = new BlockNode();

        public BrIfNode(BaseNode condition) {
            Condition = condition;
        }

        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br_if 0");
            writer.Indent();
            Condition?.ToSExpressionString(writer);
            foreach(var node in Block.Nodes) {
                node.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
