using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class CallNode : ExecutableNode {

        public CallNode(FunctionNode func) {
            Function = func;
        }

        public FunctionNode Function { get; set; }

        public IList<ExecutableNode> Arguments { get; } = new List<ExecutableNode>();

        public override WasmType ResultType => Function.Signature.Return;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("call");
            foreach (var arg in Arguments) {
                writer.EnsureNewLine();
                arg.ToString(writer);
            }
            if (Arguments.Count > 0) writer.EnsureNewLine();
            writer.CloseNode();
        }

    }
}
