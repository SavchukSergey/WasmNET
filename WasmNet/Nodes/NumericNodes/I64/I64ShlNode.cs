namespace WasmNet.Nodes {
    public class I64ShlNode : I64BinaryNumericNode {

        public I64ShlNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shl";

    }
}