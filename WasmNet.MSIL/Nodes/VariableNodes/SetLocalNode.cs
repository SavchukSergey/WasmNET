using WasmNet.Data;

namespace WasmNet.Nodes {
    public class SetLocalNode : ExecutableNode {

        public LocalNode Variable { get; }

        public ExecutableNode Value { get; }

        public SetLocalNode(LocalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("set_local");
            writer.WriteVariableName(Variable);
            writer.EnsureSpace();
            Value.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}