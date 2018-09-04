using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I64BinaryComparisionNode : BinaryComparisionNode {

        protected I64BinaryComparisionNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.I64;

    }
}
