using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class CallIndirectNode : ExecutableNode {

        public WasmFunctionSignature Type { get; set; }

        public ExecutableNode Element { get; set; }

        public IList<ExecutableNode> Arguments { get; } = new List<ExecutableNode>();

        public CallIndirectNode(WasmFunctionSignature type, ExecutableNode element) {
            Type = type;
            Element = element;
        }

        public override WasmType ResultType => Type.Return;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(call_indirect");

            writer.Indent();
            Element?.ToString(writer);
            foreach (var arg in Arguments) {
                arg.ToString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
