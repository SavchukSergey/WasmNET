namespace WasmNet.Nodes {
    public class I64EqNode : I64BinaryComparisionNode {

        public I64EqNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.eq";

    }
}
