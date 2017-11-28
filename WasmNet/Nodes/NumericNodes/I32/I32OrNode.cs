namespace WasmNet.Nodes {
    public class I32OrNode : I32BinaryNumericNode {

        public I32OrNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.or";

    }
}