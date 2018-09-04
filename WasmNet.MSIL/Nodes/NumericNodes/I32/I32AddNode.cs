namespace WasmNet.Nodes {
    public class I32AddNode : I32BinaryNumericNode {

        public I32AddNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.add";

    }
}