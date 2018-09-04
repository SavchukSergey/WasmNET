namespace WasmNet.Nodes {
    public class F64NegNode : F64UnaryNumericNode {

        public F64NegNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.neg";

    }
}