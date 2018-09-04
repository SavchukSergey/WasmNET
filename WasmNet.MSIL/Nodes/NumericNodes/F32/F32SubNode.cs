namespace WasmNet.Nodes {
    public class F32SubNode : F32BinaryNumericNode {

        public F32SubNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.sub";

    }
}