using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class I32BinaryNumericNode : BinaryNumericNode {

        protected I32BinaryNumericNode(BaseNode left, BaseNode right) : base(left, right) {
        }

        public override WasmType ResultType => WasmType.I32;

    }
}
