namespace WasmNet.Nodes {
    public class F64SqrtNode : F64UnaryNumericNode {

        public F64SqrtNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f64.sqrt";

    }
}