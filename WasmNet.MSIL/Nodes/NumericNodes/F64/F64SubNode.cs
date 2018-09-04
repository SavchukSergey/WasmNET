namespace WasmNet.Nodes {
    public class F64SubNode : F64BinaryNumericNode {

        public F64SubNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.sub";

    }
}