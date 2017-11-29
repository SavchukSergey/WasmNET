namespace WasmNet.Nodes {
    public class F64EqNode : F32BinaryComparisionNode {

        public F64EqNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.eq";

    }
}
