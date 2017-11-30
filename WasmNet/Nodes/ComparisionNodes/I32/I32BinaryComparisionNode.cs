using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I32BinaryComparisionNode : BinaryComparisionNode {

        protected I32BinaryComparisionNode(ExecutableNode left, ExecutableNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.I32;

    }
}
