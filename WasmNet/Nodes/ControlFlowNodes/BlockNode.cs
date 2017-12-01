using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BlockNode : ExecutableNode {

        private WasmType _resultType;
        public LinkedList<ExecutableNode> Nodes { get; } = new LinkedList<ExecutableNode>();

        public string Label { get; set; }

        public BlockNode(WasmType signature) {
            _resultType = signature;
        }

        public override WasmType ResultType => _resultType;

        public WasmType ActualResultType {
            get {
                //all extra values are ignored
                var walker = Nodes.Last;
                while (walker != null) {
                    var type = walker.Value.ResultType;
                    if (type != WasmType.BlockType) return type;
                    walker = walker.Previous;
                }
                return WasmType.BlockType;
            }
        }

        public void Push(ExecutableNode node) {
            Nodes.AddLast(node);
        }

        public ExecutableNode Pop() {
            var last = Nodes.Last;
            Nodes.RemoveLast();
            return last.Value;
        }

        public override void ToString(NodeWriter writer) {
            writer.NewLine();
            writer.OpenNode("block");
            if (ResultType != WasmType.BlockType) {
                writer.Write(" ");
                writer.Write(ConvertType(ResultType));
            }
            if (!string.IsNullOrWhiteSpace(Label)) {
                writer.Write("$");
                writer.Write(Label);
            }
            writer.NewLine();
            foreach (var node in Nodes) {
                node.ToString(writer);
            }
            writer.CloseNode();
            writer.NewLine();
        }

    }
}
