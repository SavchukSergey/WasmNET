namespace WasmNet.Nodes {
    public class F64GeNode : F64BinaryComparisionNode {

        public F64GeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.ge";

    }
}
