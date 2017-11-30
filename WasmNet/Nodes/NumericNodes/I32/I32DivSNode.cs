namespace WasmNet.Nodes {
    public class I32DivSNode : I32BinaryNumericNode {

        public I32DivSNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.div_s";

    }
}