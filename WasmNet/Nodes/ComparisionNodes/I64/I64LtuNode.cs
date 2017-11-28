namespace WasmNet.Nodes {
    public class I64LtuNode : BinaryNumericNode {

        public I64LtuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.lt_u";

    }
}
