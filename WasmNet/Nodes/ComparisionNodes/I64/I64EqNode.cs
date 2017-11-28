namespace WasmNet.Nodes {
    public class I64EqNode : BinaryNumericNode {

        public I64EqNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.eq";

    }
}
