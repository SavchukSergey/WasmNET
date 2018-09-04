namespace WasmNet.Nodes {
    public class I64CtzNode : I64UnaryNumericNode {

        public I64CtzNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i64.ctz";

    }
}