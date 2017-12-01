using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class NodesList {

        private LinkedList<ExecutableNode> _nodes = new LinkedList<ExecutableNode>();

        public NodesList(WasmType signature) {
            Signature = signature;
        }

        public WasmType Signature { get; }

        public Label Label { get; } = new Label();

        public WasmType ActualResultType {
            get {
                //all extra values are ignored
                var walker = _nodes.Last;
                while (walker != null) {
                    var type = walker.Value.ResultType;
                    if (type != WasmType.BlockType) return type;
                    walker = walker.Previous;
                }
                return WasmType.BlockType;
            }
        }

        public void Push(ExecutableNode node) {
            _nodes.AddLast(node);
        }

        public ExecutableNode Pop() {
            var last = _nodes.Last;
            _nodes.RemoveLast();
            return last.Value;
        }

        public void ToString(NodeWriter writer) {
            foreach (var node in _nodes) {
                writer.EnsureNewLine();
                node.ToString(writer);
            }
        }

    }
}
