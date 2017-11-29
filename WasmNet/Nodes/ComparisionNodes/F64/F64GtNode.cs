namespace WasmNet.Nodes {
    public class F64GtNode : I32BinaryComparisionNode {

        public F64GtNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.gt";

    }
}
