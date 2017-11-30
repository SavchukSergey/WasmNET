using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Load32UNode : MemoryLoadNode {

        public I64Load32UNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I64;

        protected override string NodeName => "i64.load32_u";

    }
}