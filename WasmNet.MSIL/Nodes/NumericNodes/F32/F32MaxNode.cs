namespace WasmNet.Nodes {
    public class F32MaxNode : F32BinaryNumericNode {

        public F32MaxNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.max";

    }
}