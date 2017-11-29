namespace WasmNet.Nodes {
    public class F32NeNode : I32BinaryComparisionNode {

        public F32NeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.ne";

    }
}
