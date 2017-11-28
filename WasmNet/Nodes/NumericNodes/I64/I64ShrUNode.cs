namespace WasmNet.Nodes {
    public class I64ShrUNode : BinaryNumericNode {

        public I64ShrUNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shr_u";

    }
}