namespace WasmNet.Nodes {
    public class SetGlobalNode : BaseNode {

        public SetGlobalNode(GlobalVariable variable, BaseNode value) {
            Variable = variable;
            Value = value;
        }

        public GlobalVariable Variable { get; set; }

        public BaseNode Value { get; set; }

        public override void ToString(NodeWriter writer) {
            writer.StartLine();
            writer.Write($"{Variable.Name} = ");
            Value.ToString(writer);
            writer.Write(";");
            writer.EndLine();
        }

    }
}