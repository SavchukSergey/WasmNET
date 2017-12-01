﻿using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BlockNode : ExecutableNode {

        public NodesList Nodes { get; }

        public BlockNode(WasmType signature) {
            Nodes = new NodesList(signature);
        }

        public override WasmType ResultType => Nodes.Signature;

        public WasmType ActualResultType => Nodes.ActualResultType;

        public override void ToString(NodeWriter writer) {
            writer.NewLine();
            writer.OpenNode("block");
            if (ResultType != WasmType.BlockType) {
                writer.EnsureSpace();
                writer.Write(ConvertType(ResultType));
            }
            if (!string.IsNullOrWhiteSpace(Nodes.Label.Name)) {
                writer.EnsureSpace();
                writer.Write("$");
                writer.Write(Nodes.Label.Name);
            }
            writer.NewLine();
            Nodes.ToString(writer);
            writer.CloseNode();
            writer.NewLine();
        }

    }
}
