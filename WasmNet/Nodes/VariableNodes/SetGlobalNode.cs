using WasmNet.Data;

namespace WasmNet.Nodes {
    public class SetGlobalNode : ExecutableNode {

        public GlobalNode Variable { get; }

        public ExecutableNode Value { get; }

        public SetGlobalNode(GlobalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.WriteLine($"(set_global ${Variable.Name}");
            writer.Indent();
            Value?.ToString(writer);
            writer.Unindent();
            writer.WriteLine(")");
        }

    }
}