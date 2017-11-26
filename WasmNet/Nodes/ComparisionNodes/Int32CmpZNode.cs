namespace WasmNet.Nodes {
    public class Int32CmpZNode : BaseNode {

        public Int32CmpZNode(BaseNode expr) {
            Expression = expr;
        }

        public BaseNode Expression { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.Write($"({Expression} == 0)");
        }

    }
}
