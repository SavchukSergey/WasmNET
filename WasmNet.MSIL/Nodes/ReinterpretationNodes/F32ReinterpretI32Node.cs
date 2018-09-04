using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F32ReinterpretI32Node : ReinterpretationNode {

        public F32ReinterpretI32Node(ExecutableNode expression) : base(expression) {
        }

        protected override string NodeName => "f32.reinterpret/i32";

        protected override WasmType OperandType => WasmType.I32;

        public override WasmType ResultType => WasmType.F32;

    }
}
