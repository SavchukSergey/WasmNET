namespace WasmNet.Nodes {
    public class I64OrNode : I64BinaryNumericNode {

        public I64OrNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.or";

    }
}