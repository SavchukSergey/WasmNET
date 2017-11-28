namespace WasmNet.Nodes {
    public class I64LesNode : BinaryComparisionNode {

        public I64LesNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.le_s";

    }
}
