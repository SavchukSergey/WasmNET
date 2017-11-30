using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ReinterpretI64Node : ReinterpretationNode {

        public F64ReinterpretI64Node(ExecutableNode expression) : base(expression) {
        }

        protected override string NodeName  => "f64.reinterpret/i64";

        protected override WasmType OperandType => WasmType.I64;

        public override WasmType ResultType => WasmType.F64;

    }
}
