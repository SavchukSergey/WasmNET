namespace WasmNet.Nodes {
    public class I64ShrSNode : BinaryNumericNode {

        public I64ShrSNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shr_s";

    }
}