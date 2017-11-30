namespace WasmNet.Nodes {
    public class F64AddNode : F64BinaryNumericNode {

        public F64AddNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.add";

    }
}