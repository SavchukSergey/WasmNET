namespace WasmNet.Nodes {
    public class F32GtNode : F32BinaryComparisionNode {

        public F32GtNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.gt";

    }
}
