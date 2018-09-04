namespace WasmNet.Nodes {
    public class F32MinNode : F32BinaryNumericNode {

        public F32MinNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.min";

    }
}