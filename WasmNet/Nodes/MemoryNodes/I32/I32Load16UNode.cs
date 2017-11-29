using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Load16UNode : MemoryLoadNode {

        public I32Load16UNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override WasmType ResultType => WasmType.I32;

        protected override string NodeName => "i32.load16_u";

    }
}