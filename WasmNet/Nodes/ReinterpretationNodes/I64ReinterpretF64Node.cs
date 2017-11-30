using WasmNet.Data;

namespace WasmNet.Nodes {
    public class I64ReinterpretF64Node : ReinterpretationNode {

        public I64ReinterpretF64Node(ExecutableNode expression) : base(expression) {
        }

        protected override string NodeName => "i64.reinterpret/f64";

        protected override WasmType OperandType => WasmType.F64;

        public override WasmType ResultType => WasmType.I64;

    }
}
