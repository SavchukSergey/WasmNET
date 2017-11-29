namespace WasmNet.Nodes {
    public class I64LeuNode : I64BinaryComparisionNode {

        public I64LeuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.le_u";

    }
}
