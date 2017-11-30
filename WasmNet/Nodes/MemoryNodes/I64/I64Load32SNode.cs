using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Load32SNode : MemoryLoadNode {

        public I64Load32SNode(WasmMemoryImmediate immediate, ExecutableNode address) : base(immediate, address) {
        }

        public override WasmType ResultType => WasmType.I64;

        protected override string NodeName => "i64.load32_s";

    }
}