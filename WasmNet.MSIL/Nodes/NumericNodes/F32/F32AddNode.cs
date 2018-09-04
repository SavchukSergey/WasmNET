namespace WasmNet.Nodes {
    public class F32AddNode : F32BinaryNumericNode {

        public F32AddNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.add";

    }
}