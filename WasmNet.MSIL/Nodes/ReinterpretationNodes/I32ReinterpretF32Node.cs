using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I32ReinterpretF32Node : ReinterpretationNode {

        public I32ReinterpretF32Node(ExecutableNode expression) : base(expression) {
        }

        protected  override string NodeName => "i32.reinterpret/f32";

        protected override WasmType OperandType => WasmType.F32;

        public override WasmType ResultType => WasmType.I32;

    }
}
