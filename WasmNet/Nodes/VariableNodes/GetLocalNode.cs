namespace WasmNet.Nodes {
    public class GetLocalNode : BaseNode {

        public LocalNode Variable { get; set; }

        public GetLocalNode(LocalNode variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write(Variable.Name);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(get_local ${Variable.Name})");
        }

    }
}