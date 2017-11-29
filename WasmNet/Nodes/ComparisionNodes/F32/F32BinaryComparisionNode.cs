using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F32BinaryComparisionNode : BinaryComparisionNode {

        public F32BinaryComparisionNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.F32;

    }
}
