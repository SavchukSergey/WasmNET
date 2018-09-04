namespace WasmNet.Nodes {
    public class F64DivNode : F64BinaryNumericNode {

        public F64DivNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.div";

    }
}