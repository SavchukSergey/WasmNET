namespace WasmNet.Nodes {
    public class I64GtuNode : I64BinaryComparisionNode {

        public I64GtuNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.gt_u";

    }
}
