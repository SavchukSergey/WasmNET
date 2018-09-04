namespace WasmNet.Nodes {
    public class I32ShrSNode : I32BinaryNumericNode {

        public I32ShrSNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.shr_s";

    }
}