namespace WasmNet.Nodes {
    public class I64ShlNode : BinaryNumericNode {

        public I64ShlNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i64.shl";

    }
}