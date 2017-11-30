namespace WasmNet.Nodes {
    public class I64RemUNode : I64BinaryNumericNode {

        public I64RemUNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.rem_u";

    }
}