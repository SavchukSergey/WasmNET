using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Store32Node : MemoryStoreNode {

        public I64Store32Node(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I64;

        protected override string NodeName => "i64.store32";

    }
}