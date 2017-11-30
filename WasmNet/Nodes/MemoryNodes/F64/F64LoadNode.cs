using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64LoadNode : MemoryLoadNode {

        public F64LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override WasmType ResultType => WasmType.F64;

        protected override string NodeName => "f64.load";

    }
}