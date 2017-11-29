namespace WasmNet.Nodes {
    public class I64MulNode : I64BinaryNumericNode {

        public I64MulNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.mul";

    }
}