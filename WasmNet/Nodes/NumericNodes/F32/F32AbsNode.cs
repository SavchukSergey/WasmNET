namespace WasmNet.Nodes {
    public class F32AbsNode : F32UnaryNumericNode {

        public F32AbsNode(BaseNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.abs";

    }
}