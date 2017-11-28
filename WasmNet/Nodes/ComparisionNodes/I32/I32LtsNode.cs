namespace WasmNet.Nodes {
    public class I32LtsNode : BinaryNumericNode {

        public I32LtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.lt_s";

    }
}
