namespace WasmNet.Nodes {
    public class F64MaxNode : F64BinaryNumericNode {

        public F64MaxNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.max";

    }
}