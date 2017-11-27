namespace WasmNet.Nodes {
    public class I32AndNode : BinaryNumericNode {

        public I32AndNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.and";

    }
}