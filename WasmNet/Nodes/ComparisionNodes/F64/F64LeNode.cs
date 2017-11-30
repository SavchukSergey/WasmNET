namespace WasmNet.Nodes {
    public class F64LeNode : F64BinaryComparisionNode {

        public F64LeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.le";

    }
}
