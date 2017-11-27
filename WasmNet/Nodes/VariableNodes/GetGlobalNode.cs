﻿namespace WasmNet.Nodes {
    public class GetGlobalNode : BaseNode {

        public GlobalNode Variable { get; set; }

        public GetGlobalNode(GlobalNode variable) {
            Variable = variable;
        }

        public override void ToString(NodeWriter writer) {
            writer.Write(Variable.Name);
        }

        public override void ToSExpressionString(NodeWriter writer) {
            writer.WriteLine($"(get_global ${Variable.Name})");
        }

    }
}