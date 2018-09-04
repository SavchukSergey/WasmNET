namespace WasmNet.Nodes {
    public class F32LtNode : F32BinaryComparisionNode {

        public F32LtNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.lt";

    }
}
