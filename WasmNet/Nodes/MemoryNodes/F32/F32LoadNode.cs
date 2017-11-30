using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32LoadNode : MemoryLoadNode {

        public F32LoadNode(WasmMemoryImmediate immediate, BaseNode address) : base(immediate, address) {
        }

        public override void ToString(NodeWriter writer) => throw new System.NotImplementedException();

        public override WasmType ResultType => WasmType.F32;

        protected override string NodeName => "f32.load";

    }
}