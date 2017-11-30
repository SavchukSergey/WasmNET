using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F64UnaryNumericNode : UnaryNumericNode {

        protected F64UnaryNumericNode(BaseNode expr) : base(expr) {
        }

        public override WasmType ResultType => WasmType.F64;

    }
}
