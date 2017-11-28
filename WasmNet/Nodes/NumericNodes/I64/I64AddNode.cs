namespace WasmNet.Nodes {
    public class I64AddNode : I64BinaryNumericNode {

        public I64AddNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.add";

    }
}