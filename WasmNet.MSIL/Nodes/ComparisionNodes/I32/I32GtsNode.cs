namespace WasmNet.Nodes {
    public class I32GtsNode : I32BinaryComparisionNode {

        public I32GtsNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.gt_s";

    }
}
