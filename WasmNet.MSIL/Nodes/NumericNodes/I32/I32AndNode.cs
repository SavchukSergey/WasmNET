namespace WasmNet.Nodes {
    public class I32AndNode : I32BinaryNumericNode {

        public I32AndNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.and";

    }
}