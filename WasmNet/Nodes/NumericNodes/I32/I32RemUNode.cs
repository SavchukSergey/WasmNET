namespace WasmNet.Nodes {
    public class I32RemUNode : I32BinaryNumericNode {

        public I32RemUNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.rem_u";

    }
}