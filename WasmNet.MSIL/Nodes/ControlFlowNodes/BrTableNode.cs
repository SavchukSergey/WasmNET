using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrTableNode : ExecutableNode {

        public ExecutableNode Operand { get; set; }

        public IList<Label> Targets { get; } = new List<Label>();

        public Label DefaultTarget { get; set; }

        public override WasmType ResultType => WasmType.BlockType;

        public BrTableNode(ExecutableNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) {
            writer.EnsureNewLine();
            writer.OpenNode("br_table");
            foreach (var target in Targets) {
                writer.EnsureNewLine();
                writer.WriteLabelName(target);
            }
            writer.EnsureNewLine();
            writer.WriteLabelName(DefaultTarget);
            writer.CloseNode();
            //todo: syntax?
        }

    }
}
