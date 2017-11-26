using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class BlockNode : BaseNode {

        public IList<BaseNode> Nodes { get; } = new List<BaseNode>();

        public void Add(BaseNode node) {
            Nodes.Add(node);
        }

        public override void ToString(NodeWriter writer) {
            foreach (var node in Nodes) {
                node.ToString(writer);
            }
        }

    }
}
