using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ExecutableNode : BaseNode {

        public abstract WasmType ResultType { get; }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

    }
}
