namespace WasmNet.Nodes {
    public class I64ShrSNode : I64BinaryNumericNode {

        public I64ShrSNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shr_s";

    }
}