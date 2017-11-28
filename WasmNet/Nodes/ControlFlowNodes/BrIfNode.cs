using System;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrIfNode : BaseNode {

        public BaseNode Condition { get; }

        public BlockNode Block { get; } = new BlockNode(WasmType.BlockType);

        public BrIfNode(BaseNode condition) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 operand");
            Condition = condition;
        }

        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br_if 0");
            writer.Indent();
            Condition?.ToSExpressionString(writer);
            foreach (var node in Block.Nodes) {
                node.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
