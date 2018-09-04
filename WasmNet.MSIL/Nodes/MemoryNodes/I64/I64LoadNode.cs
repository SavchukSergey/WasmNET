using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64LoadNode : MemoryLoadNode {

        public I64LoadNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I64;

        protected override string NodeName => "i64.load";

    }
}