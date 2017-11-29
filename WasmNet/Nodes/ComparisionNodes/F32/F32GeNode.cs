namespace WasmNet.Nodes {
    public class F32GeNode : I32BinaryComparisionNode {

        public F32GeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.ge";

    }
}
