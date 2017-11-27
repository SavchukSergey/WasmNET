namespace WasmNet.Nodes {
    public class I32ShlNode : BinaryNumericNode {

        public I32ShlNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.shl";

    }
}