using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32StoreNode : MemoryStoreNode {

        public F32StoreNode(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.F32;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "f32.store";

    }
}