using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F32UnaryNumericNode : UnaryNumericNode {

        protected F32UnaryNumericNode(BaseNode expr) : base(expr) {
        }

        public override WasmType ResultType => WasmType.F32;

    }
}
