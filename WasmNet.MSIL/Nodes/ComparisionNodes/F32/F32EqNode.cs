namespace WasmNet.Nodes {
    public class F32EqNode : F32BinaryComparisionNode {

        public F32EqNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected override string NodeName => "f32.eq";

    }
}
