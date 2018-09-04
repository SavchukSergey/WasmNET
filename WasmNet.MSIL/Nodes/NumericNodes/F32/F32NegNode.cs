namespace WasmNet.Nodes {
    public class F32NegNode : F32UnaryNumericNode {

        public F32NegNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.neg";

    }
}