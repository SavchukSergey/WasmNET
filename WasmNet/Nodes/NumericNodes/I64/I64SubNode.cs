namespace WasmNet.Nodes {
    public class I64SubNode : I64BinaryNumericNode {

        public I64SubNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.sub";

    }
}