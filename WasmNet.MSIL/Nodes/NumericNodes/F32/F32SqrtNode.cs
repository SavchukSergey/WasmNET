namespace WasmNet.Nodes {
    public class F32SqrtNode : F32UnaryNumericNode {

        public F32SqrtNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "f32.sqrt";

    }
}