namespace WasmNet.Nodes {
    public class F64LeNode : I32BinaryComparisionNode {

        public F64LeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.le";

    }
}
