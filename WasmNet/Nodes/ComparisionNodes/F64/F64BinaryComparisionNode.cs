using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F64BinaryComparisionNode : BinaryComparisionNode {

        protected F64BinaryComparisionNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.F64;

    }
}
