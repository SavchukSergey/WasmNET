using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class CallIndirectNode : ExecutableNode {

        public WasmFunctionSignature Type { get; }

        public ExecutableNode Element { get; }

        public IList<ExecutableNode> Arguments { get; } = new List<ExecutableNode>();

        public CallIndirectNode(WasmFunctionSignature type, ExecutableNode element) {
            Type = type;
            Element = element;
        }

        public override WasmType ResultType => Type.Return;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("call_indirect");

            if (Arguments.Count > 0) writer.EnsureNewLine();
            else writer.EnsureSpace();

            Element.ToString(writer);

            foreach (var arg in Arguments) {
                writer.EnsureNewLine();
                arg.ToString(writer);
            }

            if (Arguments.Count > 0) writer.EnsureNewLine();
            writer.CloseNode();
        }

    }
}
