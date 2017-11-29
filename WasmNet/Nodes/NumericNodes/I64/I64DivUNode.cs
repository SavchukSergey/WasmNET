namespace WasmNet.Nodes {
    public class I64DivUNode : I32BinaryNumericNode {

        public I64DivUNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.div_u";

    }
}