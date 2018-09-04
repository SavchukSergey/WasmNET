namespace WasmNet.Nodes {
    public class I64RotlNode : I64BinaryNumericNode {

        public I64RotlNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.rotl";

    }
}