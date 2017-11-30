namespace WasmNet.Nodes {
    public class F32DivNode : F32BinaryNumericNode {

        public F32DivNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.div";

    }
}