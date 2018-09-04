namespace WasmNet.Nodes {
    public class F64NeNode : F64BinaryComparisionNode {

        public F64NeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.ne";

    }
}
