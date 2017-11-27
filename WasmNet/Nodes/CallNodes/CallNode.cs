using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class CallNode : BaseNode {

        public CallNode(FunctionNode func) {
            Function = func;
        }

        public FunctionNode Function { get; set; }

        public IList<BaseNode> Arguments { get; } = new List<BaseNode>();

        public override void ToString(NodeWriter writer) {
            writer.Write(Function.Name);
            writer.Write("(");
            for (var i = 0; i < Arguments.Count; i++) {
                if (i != 0) writer.Write(", ");
                Arguments[i].ToString(writer);
            }
            writer.Write(")");
        }

        public override void ToSExpressionString(NodeWriter writer) {
        }

    }
}
