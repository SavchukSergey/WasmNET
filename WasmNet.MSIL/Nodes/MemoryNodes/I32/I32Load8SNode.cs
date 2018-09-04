using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Load8SNode : MemoryLoadNode {

        public I32Load8SNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I32;

        protected override string NodeName => "i32.load8_s";

    }
}