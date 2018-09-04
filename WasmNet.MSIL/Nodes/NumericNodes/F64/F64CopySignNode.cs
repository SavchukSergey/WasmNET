namespace WasmNet.Nodes {
    public class F64CopySignNode : F64BinaryNumericNode {

        public F64CopySignNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f64.copysign";

    }
}