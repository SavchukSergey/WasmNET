namespace WasmNet.Nodes {
    public class F64FloorNode : F64UnaryNumericNode {

        public F64FloorNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.floor";

    }
}