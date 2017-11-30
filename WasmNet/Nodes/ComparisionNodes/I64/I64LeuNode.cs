namespace WasmNet.Nodes {
    public class I64LeuNode : I64BinaryComparisionNode {

        public I64LeuNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.le_u";

    }
}
