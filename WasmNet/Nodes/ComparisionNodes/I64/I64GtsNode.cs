namespace WasmNet.Nodes {
    public class I64GtsNode : BinaryComparisionNode {

        public I64GtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.gt_s";

    }
}
