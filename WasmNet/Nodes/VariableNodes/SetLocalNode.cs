using WasmNet.Data;

namespace WasmNet.Nodes {
    public class SetLocalNode : ExecutableNode {

        public LocalNode Variable { get; }

        public BaseNode Value { get; }

        public SetLocalNode(LocalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.OpenNode("set_local");
            writer.EnsureSpace();
            writer.Write($"${Variable.Name}");
            writer.EnsureSpace();
            Value.ToString(writer);
            writer.CloseNode();
        }

    }
}