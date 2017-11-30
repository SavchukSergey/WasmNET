namespace WasmNet.Nodes {
    public class I32RotlNode : I32BinaryNumericNode {

        public I32RotlNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.rotl";

    }
}