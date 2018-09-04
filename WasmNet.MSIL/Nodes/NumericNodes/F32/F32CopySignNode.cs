namespace WasmNet.Nodes {
    public class F32CopySignNode : F32BinaryNumericNode {

        public F32CopySignNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.copysign";

    }
}