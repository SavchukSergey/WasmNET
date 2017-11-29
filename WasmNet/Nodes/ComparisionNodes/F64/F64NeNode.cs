namespace WasmNet.Nodes {
    public class F64NeNode : I32BinaryComparisionNode {

        public F64NeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.ne";

    }
}
