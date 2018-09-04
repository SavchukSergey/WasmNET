using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Store16Node : MemoryStoreNode {

        public I32Store16Node(WasmMemoryImmediate immediate, ExecutableNode address, ExecutableNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I32;

        protected override string NodeName => "i32.store16";

    }
}