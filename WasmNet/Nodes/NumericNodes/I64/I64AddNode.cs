namespace WasmNet.Nodes {
    public class I64AddNode : I64BinaryNumericNode {

        public I64AddNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.add";

    }
}