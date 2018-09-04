namespace WasmNet.Nodes {
    public class F64AbsNode : F64UnaryNumericNode {

        public F64AbsNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.abs";

    }
}