namespace WasmNet.Nodes {
    public class I32ClzNode : I32UnaryNumericNode {

        public I32ClzNode(ExecutableNode expr) : base(expr) {
        }

        protected override string NodeName => "i32.clz";

    }
}