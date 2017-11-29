namespace WasmNet.Nodes {
    public class F32EqNode : F32BinaryComparisionNode {

        public F32EqNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.eq";

    }
}
