namespace WasmNet.Nodes {
    public class I32GeuNode : I32BinaryComparisionNode {

        public I32GeuNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.ge_u";

    }
}
