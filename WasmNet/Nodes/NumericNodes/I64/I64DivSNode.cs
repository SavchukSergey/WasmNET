namespace WasmNet.Nodes {
    public class I64DivSNode : BinaryNumericNode {

        public I64DivSNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.div_s";

    }
}