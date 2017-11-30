using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Load16UNode : MemoryLoadNode {

        public I32Load16UNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I32;

        protected override string NodeName => "i32.load16_u";

    }
}