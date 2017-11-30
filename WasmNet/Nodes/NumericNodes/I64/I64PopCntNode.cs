namespace WasmNet.Nodes {
    public class I64PopCntNode : I64UnaryNumericNode {

        public I64PopCntNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i64.popcnt";

    }
}