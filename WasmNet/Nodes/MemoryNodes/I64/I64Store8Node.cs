using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Store8Node : MemoryStoreNode {

        public I64Store8Node(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        protected override WasmType ValueType => WasmType.I64;

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i64.store8";

    }
}