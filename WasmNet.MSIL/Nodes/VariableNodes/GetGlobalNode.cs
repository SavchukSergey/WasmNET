using WasmNet.Data;

namespace WasmNet.Nodes {
    public class GetGlobalNode : ExecutableNode {

        public GlobalNode Variable { get; }

        public override WasmType ResultType => Variable.Type;

        public GetGlobalNode(GlobalNode variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.OpenNode($"get_global");
            writer.EnsureSpace();
            writer.Write($"${Variable.Name}");
            writer.CloseNode();
        }

    }
}