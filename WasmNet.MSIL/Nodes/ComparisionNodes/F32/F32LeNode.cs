namespace WasmNet.Nodes {
    public class F32LeNode : F32BinaryComparisionNode {

        public F32LeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.le";

    }
}
