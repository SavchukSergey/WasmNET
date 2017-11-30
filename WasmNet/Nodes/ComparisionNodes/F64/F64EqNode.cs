namespace WasmNet.Nodes {
    public class F64EqNode : F64BinaryComparisionNode {

        public F64EqNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.eq";

    }
}
