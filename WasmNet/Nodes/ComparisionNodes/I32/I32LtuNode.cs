namespace WasmNet.Nodes {
    public class I32LtuNode : I32BinaryComparisionNode {

        public I32LtuNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.lt_u";

    }
}
