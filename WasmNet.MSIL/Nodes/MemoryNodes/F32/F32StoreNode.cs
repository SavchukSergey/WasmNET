using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32StoreNode : MemoryStoreNode {

        public F32StoreNode(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.F32;

        protected override string NodeName => "f32.store";

    }
}