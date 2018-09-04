namespace WasmNet.Nodes {
    public class F64TruncNode : F64UnaryNumericNode {

        public F64TruncNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.trunc";

    }
}