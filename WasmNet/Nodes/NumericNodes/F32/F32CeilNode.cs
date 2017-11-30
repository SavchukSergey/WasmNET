namespace WasmNet.Nodes {
    public class F32CeilNode : F32UnaryNumericNode {

        public F32CeilNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.ceil";

    }
}