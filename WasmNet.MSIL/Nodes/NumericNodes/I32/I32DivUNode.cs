namespace WasmNet.Nodes {
    public class I32DivUNode : I32BinaryNumericNode {

        public I32DivUNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.div_u";

    }
}