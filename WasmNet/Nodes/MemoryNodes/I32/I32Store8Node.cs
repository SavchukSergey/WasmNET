using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32Store8Node : MemoryStoreNode {

        public I32Store8Node(WasmMemoryImmediate immediate, BaseNode address, BaseNode value) : base(immediate, address, value) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        protected override string NodeName => "i32.store8";

    }
}