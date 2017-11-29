namespace WasmNet.Nodes {
    public class F32LeNode : I32BinaryComparisionNode {

        public F32LeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.le";

    }
}
