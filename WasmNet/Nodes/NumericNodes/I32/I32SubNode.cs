namespace WasmNet.Nodes {
    public class I32SubNode : BinaryNumericNode {

        public I32SubNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected override string NodeName => "i32.sub";

    }
}