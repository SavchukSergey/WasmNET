namespace WasmNet.Nodes {
    public class I64RotrNode : I64BinaryNumericNode {

        public I64RotrNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.rotr";

    }
}