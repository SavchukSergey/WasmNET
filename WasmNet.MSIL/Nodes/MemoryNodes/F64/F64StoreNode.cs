using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64StoreNode : MemoryStoreNode {

        public F64StoreNode(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.F64;

        protected override string NodeName => "f64.store";

    }
}