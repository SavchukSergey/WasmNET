﻿using WasmNet.Data;

namespace WasmNet.Nodes {
    public class SetGlobalNode : ExecutableNode {

        public GlobalNode Variable { get; }

        public ExecutableNode Value { get; }

        public SetGlobalNode(GlobalNode variable, ExecutableNode value) {
            if (variable.Type != value.ResultType) throw new WasmNodeException($"cannot assign {value.ResultType} to {variable.Type} variable");
            if (!variable.Mutable) throw new WasmNodeException($"cannot assign {value.ResultType} to not mutable variable");
            Variable = variable;
            Value = value;
        }

        public override WasmType ResultType => WasmType.BlockType;

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("set_global");
            writer.EnsureSpace();
            writer.Write($"${Variable.Name}");
            writer.EnsureSpace();
            Value.ToString(writer);
            writer.CloseNode();
            writer.EnsureNewLine();
        }

    }
}