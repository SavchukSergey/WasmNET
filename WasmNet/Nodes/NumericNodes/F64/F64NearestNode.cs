namespace WasmNet.Nodes {
    public class F64NearestNode : F64UnaryNumericNode {

        public F64NearestNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.nearest";

    }
}