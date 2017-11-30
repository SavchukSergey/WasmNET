using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64StoreNode : MemoryStoreNode {

        public F64StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.F64;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "f64.store";

    }
}