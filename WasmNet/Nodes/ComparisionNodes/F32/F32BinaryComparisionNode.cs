using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F32BinaryComparisionNode : BinaryComparisionNode {

        protected F32BinaryComparisionNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.F32;

    }
}
