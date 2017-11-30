namespace WasmNet.Nodes {
    public class I32PopCntNode : I32UnaryNumericNode {

        public I32PopCntNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i32.popcnt";

    }
}