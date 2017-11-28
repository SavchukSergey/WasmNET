using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32LoadNode : MemoryLoadNode {

        public I32LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i32.load";

    }
}