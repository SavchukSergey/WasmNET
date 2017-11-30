namespace WasmNet.Nodes {
    public class I64ShrUNode : I64BinaryNumericNode {

        public I64ShrUNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shr_u";

    }
}