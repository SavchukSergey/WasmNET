using WasmNet.Data;

namespace WasmNet.Nodes {
    public class TeeLocalNode : ExecutableNode {

        public LocalNode Variable { get; }

        public BaseNode Value { get; }

        public TeeLocalNode(LocalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => Variable.Type;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(tee_local ${Variable.Name}");
            writer.Indent();
            Value.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}