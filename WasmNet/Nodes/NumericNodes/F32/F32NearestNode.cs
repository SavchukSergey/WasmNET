namespace WasmNet.Nodes {
    public class F32NearestNode : F32UnaryNumericNode {

        public F32NearestNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.nearest";

    }
}