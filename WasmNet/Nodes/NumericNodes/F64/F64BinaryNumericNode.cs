using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F64BinaryNumericNode : BinaryNumericNode {

        protected F64BinaryNumericNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        public override WasmType ResultType => WasmType.F64;

    }
}
