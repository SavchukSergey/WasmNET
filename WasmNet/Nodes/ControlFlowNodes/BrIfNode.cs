using System;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrIfNode : ExecutableNode {

        public ExecutableNode Condition { get; }

        public BrIfNode(ExecutableNode condition) {
            if (condition.ResultType != WasmType.I32) throw new WasmNodeException($"expected i32 operand");
            Condition = condition;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            //todo: relative depth
            writer.WriteLine("(br_if 0");
            writer.Indent();
            Condition?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
