namespace WasmNet.Nodes {
    public class I32GtuNode : I32BinaryComparisionNode {

        public I32GtuNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.gt_u";

    }
}
