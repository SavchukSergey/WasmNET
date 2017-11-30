namespace WasmNet.Nodes {
    public class F64MulNode : F64BinaryNumericNode {

        public F64MulNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.mul";

    }
}