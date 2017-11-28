namespace WasmNet.Nodes {
    public class I64GtsNode : BinaryNumericNode {

        public I64GtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.gt_s";

    }
}
