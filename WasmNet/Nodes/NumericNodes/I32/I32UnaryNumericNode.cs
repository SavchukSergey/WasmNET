using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I32UnaryNumericNode : UnaryNumericNode {

        protected I32UnaryNumericNode(ExecutableNode expr) : base(expr) {
        }

        public override WasmType ResultType => WasmType.I32;

    }
}
