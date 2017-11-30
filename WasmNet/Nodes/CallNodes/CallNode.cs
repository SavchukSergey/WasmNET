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
            writer.StartLine();
            writer.Write($"(call ${Function.Name}");
            if (Arguments.Count > 0) {
                writer.EndLine();
                writer.Indent();
                foreach (var arg in Arguments) {
                    arg.ToString(writer);
                }
                writer.Unindent();
                writer.WriteLine(")");
            } else {
                writer.Write(")");
                writer.EndLine();
            }
        }

    }
}
