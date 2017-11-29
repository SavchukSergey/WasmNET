namespace WasmNet.Nodes {
    public class I32LeuNode : I32BinaryComparisionNode {

        public I32LeuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.le_u";

    }
}
