namespace WasmNet.Nodes {
    public class I64AndNode : BinaryNumericNode {

        public I64AndNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.and";

    }
}