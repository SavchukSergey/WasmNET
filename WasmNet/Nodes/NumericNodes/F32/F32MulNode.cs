namespace WasmNet.Nodes {
    public class F32MulNode : F32BinaryNumericNode {

        public F32MulNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.mul";

    }
}