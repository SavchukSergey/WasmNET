namespace WasmNet.Nodes {
    public class F32GeNode : F32BinaryComparisionNode {

        public F32GeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.ge";

    }
}
