namespace WasmNet.Nodes {
    public class I64LesNode : I64BinaryComparisionNode {

        public I64LesNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.le_s";

    }
}
