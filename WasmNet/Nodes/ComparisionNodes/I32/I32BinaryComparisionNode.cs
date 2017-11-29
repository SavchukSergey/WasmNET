using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I32BinaryComparisionNode : BinaryComparisionNode {

        public I32BinaryComparisionNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        protected sealed override WasmType OperandType => WasmType.I32;

    }
}
