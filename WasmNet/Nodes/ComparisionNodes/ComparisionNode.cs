using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ComparisionNode : BaseNode {

        public override WasmType ResultType => WasmType.I32;

    }
}
