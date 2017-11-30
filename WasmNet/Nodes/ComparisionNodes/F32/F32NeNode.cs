namespace WasmNet.Nodes {
    public class F32NeNode : F32BinaryComparisionNode {

        public F32NeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.ne";

    }
}
