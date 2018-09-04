namespace WasmNet.Nodes {
    public class F64LtNode : F64BinaryComparisionNode {

        public F64LtNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.lt";

    }
}
