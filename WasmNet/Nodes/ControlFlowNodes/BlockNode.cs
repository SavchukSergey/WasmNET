using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class BlockNode : BaseNode {

        public LinkedList<BaseNode> Nodes { get; } = new LinkedList<BaseNode>();

        public void Push(BaseNode node) {
            Nodes.AddLast(node);
        }

        public BaseNode Pop() {
            var last = Nodes.Last;
            Nodes.RemoveLast();
            return last.Value;
        }

        public override void ToString(NodeWriter writer) {
            foreach (var node in Nodes) {
                node.ToString(writer);
            }
        }

        public override void ToSExpressionString(NodeWriter writer) {
            foreach (var node in Nodes) {
                node.ToSExpressionString(writer);
            }
        }

    }
}
