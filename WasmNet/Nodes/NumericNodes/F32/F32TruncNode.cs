namespace WasmNet.Nodes {
    public class F32TruncNode : F32UnaryNumericNode {

        public F32TruncNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.trunc";

    }
}