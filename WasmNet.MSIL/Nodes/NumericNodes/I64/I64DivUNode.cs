namespace WasmNet.Nodes {
    public class I64DivUNode : I64BinaryNumericNode {

        public I64DivUNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.div_u";

    }
}