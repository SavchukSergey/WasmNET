using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32LoadNode : MemoryLoadNode {

        public F32LoadNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.F32;

        protected override string NodeName => "f32.load";

    }
}