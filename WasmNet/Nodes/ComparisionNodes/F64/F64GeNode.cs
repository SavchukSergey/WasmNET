namespace WasmNet.Nodes {
    public class F64GeNode : I32BinaryComparisionNode {

        public F64GeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.ge";

    }
}
