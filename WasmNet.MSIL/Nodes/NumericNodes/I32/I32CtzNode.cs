namespace WasmNet.Nodes {
    public class I32CtzNode : I32UnaryNumericNode {

        public I32CtzNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i32.ctz";

    }
}