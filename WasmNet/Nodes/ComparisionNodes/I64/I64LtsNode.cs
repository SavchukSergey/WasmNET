namespace WasmNet.Nodes {
    public class I64LtsNode : I64BinaryComparisionNode {

        public I64LtsNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.lt_s";

    }
}
