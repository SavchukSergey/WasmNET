namespace WasmNet.Nodes {
    public class I32XorNode : BinaryNumericNode {

        public I32XorNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.xor";

    }
}