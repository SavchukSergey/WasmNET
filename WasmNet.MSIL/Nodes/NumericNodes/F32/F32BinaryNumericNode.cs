using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F32BinaryNumericNode : BinaryNumericNode {

        protected F32BinaryNumericNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        public override WasmType ResultType => WasmType.F32;

    }
}
