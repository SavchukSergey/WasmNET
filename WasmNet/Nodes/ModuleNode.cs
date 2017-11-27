using System;
using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class ModuleNode : BaseNode {

        public IList<FunctionNode> Functions { get; } = new List<FunctionNode>();

        public override void ToString(NodeWriter writer) => throw new NotImplementedException();

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine("(module ");
            writer.Indent();
            foreach (var func in Functions) {
                func.ToSExpressionString(writer);
            }
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}
