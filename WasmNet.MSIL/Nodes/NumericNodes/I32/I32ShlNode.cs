namespace WasmNet.Nodes {
    public class I32ShlNode : I32BinaryNumericNode {

        public I32ShlNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.shl";

    }
}