namespace WasmNet.Nodes {
    public class I64LtsNode : I64BinaryComparisionNode {

        public I64LtsNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.lt_s";

    }
}
