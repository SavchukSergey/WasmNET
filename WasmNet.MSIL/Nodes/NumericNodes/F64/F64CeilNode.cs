namespace WasmNet.Nodes {
    public class F64CeilNode : F64UnaryNumericNode {

        public F64CeilNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.ceil";

    }
}