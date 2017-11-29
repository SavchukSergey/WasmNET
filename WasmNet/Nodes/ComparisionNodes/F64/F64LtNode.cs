namespace WasmNet.Nodes {
    public class F64LtNode : I32BinaryComparisionNode {

        public F64LtNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.lt";

    }
}
