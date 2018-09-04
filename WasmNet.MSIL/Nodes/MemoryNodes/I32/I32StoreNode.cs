using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32StoreNode : MemoryStoreNode {

        public I32StoreNode(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I32;

        protected override string NodeName => "i32.store";

    }
}