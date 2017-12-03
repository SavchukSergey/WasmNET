using WasmNet.Data;

namespace WasmNet.Nodes {
    public class TeeLocalNode : ExecutableNode {

        public LocalNode Variable { get; }

        public ExecutableNode Value { get; }

        public TeeLocalNode(LocalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => Variable.Type;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("tee_local");
            writer.WriteVariableName(Variable);
            writer.EnsureSpace();
            Value.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}