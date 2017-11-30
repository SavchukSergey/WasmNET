namespace WasmNet.Nodes {
    public class I32RemSNode : I32BinaryNumericNode {

        public I32RemSNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.rem_s";

    }
}