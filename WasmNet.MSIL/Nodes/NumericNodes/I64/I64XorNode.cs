namespace WasmNet.Nodes {
    public class I64XorNode : I64BinaryNumericNode {

        public I64XorNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.xor";

    }
}