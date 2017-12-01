using WasmNet.Data;

namespace WasmNet.Nodes {
    public class F64ConstNode : ExecutableNode {

        public F64ConstNode(double value) {
            Value = value;
        }

        public double Value { get; set; }

        public override WasmType ResultType => WasmType.F64;

        public override void ToString(NodeWriter writer) {
            writer.OpenNode($"f64.const");
            writer.EnsureSpace();
            writer.Write(Value);
            writer.CloseNode();
        }

    }
}