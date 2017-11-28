namespace WasmNet.Nodes {
    public class I64AddNode : BinaryNumericNode {

        public I64AddNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.add";

    }
}