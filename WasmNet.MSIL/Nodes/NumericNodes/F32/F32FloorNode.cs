namespace WasmNet.Nodes {
    public class F32FloorNode : F32UnaryNumericNode {

        public F32FloorNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.floor";

    }
}