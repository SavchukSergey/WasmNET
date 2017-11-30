using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64StoreNode : MemoryStoreNode {

        public I64StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I64;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i64.store";

    }
}