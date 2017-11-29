namespace WasmNet.Nodes {
    public class I64GesNode : I64BinaryComparisionNode {

        public I64GesNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.ge_s";

    }
}
