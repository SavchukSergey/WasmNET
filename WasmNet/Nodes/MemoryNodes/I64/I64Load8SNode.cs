using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64Load8SNode : MemoryLoadNode {

        public I64Load8SNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override WasmType ResultType => WasmType.I64;

        protected override string NodeName => "i64.load8_s";

    }
}