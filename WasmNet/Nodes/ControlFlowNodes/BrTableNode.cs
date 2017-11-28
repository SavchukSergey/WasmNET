using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class BrTableNode : BaseNode {

        public BaseNode Operand { get; set; }

        public IList<uint> Targets { get; } = new List<uint>(); //tofo: frame reference

        public BaseNode Default { get; set; }

        public BrTableNode(BaseNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();
        public override void ToSExpressionString(NodeWriter writer) => throw new System.NotImplementedException();
    }
}
