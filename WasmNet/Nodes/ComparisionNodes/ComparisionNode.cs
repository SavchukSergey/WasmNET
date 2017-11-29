using WasmNet.Data;

namespace WasmNet.Nodes {
    public abstract class ComparisionNode : BaseNode {

        public override WasmType ResultType => WasmType.I32;

        protected abstract WasmType OperandType { get; }

        protected abstract string NodeName { get; }

    }
}
