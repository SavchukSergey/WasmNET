using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64StoreNode : MemoryStoreNode {

        public I64StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i64.store";

    }
}