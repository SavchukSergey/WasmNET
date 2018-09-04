namespace WasmNet.Nodes {
    public class I64ClzNode : I64UnaryNumericNode {

        public I64ClzNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i64.clz";

    }
}