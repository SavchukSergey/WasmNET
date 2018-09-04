using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I64UnaryNumericNode : UnaryNumericNode {

        protected I64UnaryNumericNode(ExecutableNode expr) : base(expr) {
        }

        public override WasmType ResultType => WasmType.I64;

    }
}
