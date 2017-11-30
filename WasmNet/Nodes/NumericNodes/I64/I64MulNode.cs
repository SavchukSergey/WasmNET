namespace WasmNet.Nodes {
    public class I64MulNode : I64BinaryNumericNode {

        public I64MulNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.mul";

    }
}