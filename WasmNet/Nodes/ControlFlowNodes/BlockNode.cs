using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class BlockNode : BaseNode {

        public Stack<BaseNode> Nodes { get; } = new Stack<BaseNode>();

        public void Push(BaseNode node) {
            Nodes.Push(node);
        }

        public BaseNode Pop() {
            return Nodes.Pop();
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
