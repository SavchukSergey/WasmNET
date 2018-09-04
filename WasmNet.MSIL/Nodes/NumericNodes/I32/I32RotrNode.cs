namespace WasmNet.Nodes {
    public class I32RotrNode : I32BinaryNumericNode {

        public I32RotrNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.rotr";

    }
}