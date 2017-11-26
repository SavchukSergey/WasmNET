namespace WasmNet.Nodes {
    public class GetLocalNode : BaseNode {

        public LocalVariable Variable { get; set; }

        public GetLocalNode(LocalVariable variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write(Variable.Name);
        }

    }
}