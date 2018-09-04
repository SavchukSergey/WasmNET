namespace WasmNet.Nodes {
    public class I32NeNode : I32BinaryComparisionNode {

        public I32NeNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.ne";

    }
}
