using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BrTableNode : ExecutableNode {

        public ExecutableNode Operand { get; set; }

        public IList<uint> Targets { get; } = new List<uint>(); //tofo: frame reference

        public uint DefaultTarget { get; set; }

        public override WasmType ResultType => WasmType.BlockType;

        public BrTableNode(ExecutableNode operand) {
            Operand = operand;
        }

        public override void ToString(NodeWriter writer) {
            //todo:
        }

    }
}
