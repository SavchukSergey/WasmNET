namespace WasmNet.Nodes {
    public class I32LtsNode : I32BinaryComparisionNode {

        public I32LtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.lt_s";

    }
}
