namespace WasmNet.Nodes {
    public class I64AndNode : I64BinaryNumericNode {

        public I64AndNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.and";

    }
}