namespace WasmNet.Nodes {
    public class I64SubNode : I64BinaryNumericNode {

        public I64SubNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.sub";

    }
}