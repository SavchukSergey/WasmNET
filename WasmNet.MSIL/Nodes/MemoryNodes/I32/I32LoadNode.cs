using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32LoadNode : MemoryLoadNode {

        public I32LoadNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I32;

        protected override string NodeName => "i32.load";

    }
}