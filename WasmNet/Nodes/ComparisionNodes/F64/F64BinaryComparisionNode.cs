using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class F64BinaryComparisionNode : BinaryComparisionNode {

        public F64BinaryComparisionNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.F64;

    }
}
