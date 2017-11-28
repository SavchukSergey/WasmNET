using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64LoadNode : MemoryLoadNode {

        public I64LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i64.load";

    }
}