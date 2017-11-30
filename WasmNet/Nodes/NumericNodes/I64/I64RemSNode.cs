namespace WasmNet.Nodes {
    public class I64RemSNode : I64BinaryNumericNode {

        public I64RemSNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.rem_s";

    }
}