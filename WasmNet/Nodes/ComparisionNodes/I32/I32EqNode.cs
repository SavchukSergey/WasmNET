namespace WasmNet.Nodes {
    public class I32EqNode : I32BinaryComparisionNode {

        public I32EqNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.eq";

    }
}
