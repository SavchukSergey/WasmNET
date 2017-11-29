using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I64BinaryComparisionNode : BinaryComparisionNode {

        public I64BinaryComparisionNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.I64;

    }
}
