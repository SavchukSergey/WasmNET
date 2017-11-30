using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GetLocalNode : ExecutableNode {

        public LocalNode Variable { get; }

        public override WasmType ResultType => Variable.Type;

        public GetLocalNode(LocalNode variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(get_local ${Variable.Name})");
        }

    }
}