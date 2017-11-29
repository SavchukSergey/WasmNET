namespace WasmNet.Nodes {
    public class F32LtNode : I32BinaryComparisionNode {

        public F32LtNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.lt";

    }
}
