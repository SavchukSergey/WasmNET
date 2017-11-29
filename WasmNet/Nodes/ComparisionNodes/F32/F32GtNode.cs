namespace WasmNet.Nodes {
    public class F32GtNode : I32BinaryComparisionNode {

        public F32GtNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.gt";

    }
}
