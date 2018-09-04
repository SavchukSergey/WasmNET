using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I64BinaryNumericNode : BinaryNumericNode {

        protected I64BinaryNumericNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        public override WasmType ResultType => WasmType.I64;

    }
}
