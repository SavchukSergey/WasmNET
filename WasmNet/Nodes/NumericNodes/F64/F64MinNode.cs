namespace WasmNet.Nodes {
    public class F64MinNode : F64BinaryNumericNode {

        public F64MinNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.min";

    }
}