namespace WasmNet.Nodes {
    public class I32GtsNode : BinaryNumericNode {

        public I32GtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.gt_s";

    }
}
