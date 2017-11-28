namespace WasmNet.Nodes {
    public class I32EqNode : BinaryNumericNode {

        public I32EqNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.eq";

    }
}
