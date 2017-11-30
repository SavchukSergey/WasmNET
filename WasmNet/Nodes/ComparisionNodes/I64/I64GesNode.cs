namespace WasmNet.Nodes {
    public class I64GesNode : I64BinaryComparisionNode {

        public I64GesNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.ge_s";

    }
}
