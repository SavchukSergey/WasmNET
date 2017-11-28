namespace WasmNet.Nodes {
    public class I64XorNode : BinaryNumericNode {

        public I64XorNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.xor";

    }
}