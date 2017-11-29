namespace WasmNet.Nodes {
    public class I32LesNode : I32BinaryComparisionNode {

        public I32LesNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.le_s";

    }
}
