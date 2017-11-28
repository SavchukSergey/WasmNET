using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GetLocalNode : BaseNode {

        public LocalNode Variable { get; set; }

        public override WasmType ResultType => Variable.ResultType;

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