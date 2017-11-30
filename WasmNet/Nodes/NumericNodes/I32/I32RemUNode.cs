namespace WasmNet.Nodes {
    public class I32RemUNode : I32BinaryNumericNode {

        public I32RemUNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.rem_u";

    }
}