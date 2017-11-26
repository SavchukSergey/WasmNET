namespace WasmNet.Nodes {
    public class GetGlobalNode : BaseNode {

        public GlobalVariable Variable { get; set; }

        public GetGlobalNode(GlobalVariable variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write(Variable.Name);
        }

    }
}