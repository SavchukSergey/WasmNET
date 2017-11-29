namespace WasmNet.Nodes {
    public class I64NeNode : I64BinaryComparisionNode {

        public I64NeNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.ne";

    }
}
