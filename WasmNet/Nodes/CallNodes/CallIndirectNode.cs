using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class CallIndirectNode : BaseNode {

        public WasmFunctionSignature Type { get; set; }

        public BaseNode Element { get; set; }

        public IList<BaseNode> Arguments { get; } = new List<BaseNode>();

        public CallIndirectNode(WasmFunctionSignature type, BaseNode element) {
            Type = type;
            Element = element;
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(call_indirect");

            writer.Indent();
            Element?.ToSExpressionString(writer);
            foreach (var arg in Arguments) {
                arg.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
