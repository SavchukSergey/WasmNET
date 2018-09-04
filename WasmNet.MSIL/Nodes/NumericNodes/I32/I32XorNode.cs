namespace WasmNet.Nodes {
    public class I32XorNode : I32BinaryNumericNode {

        public I32XorNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.xor";

    }
}