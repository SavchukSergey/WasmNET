namespace WasmNet.Nodes {
    public class F64GtNode : F64BinaryComparisionNode {

        public F64GtNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.gt";

    }
}
