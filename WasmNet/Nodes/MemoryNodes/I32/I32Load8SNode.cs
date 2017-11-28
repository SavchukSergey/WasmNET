using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Load8SNode : MemoryLoadNode {

        public I32Load8SNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i32.load8_s";

    }
}