namespace WasmNet.Nodes {
    public class I32DivSNode : BinaryNumericNode {

        public I32DivSNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.div_s";

    }
}