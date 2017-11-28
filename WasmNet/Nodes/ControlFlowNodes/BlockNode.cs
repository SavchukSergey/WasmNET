using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class BlockNode : BaseNode {

        public LinkedList<BaseNode> Nodes { get; } = new LinkedList<BaseNode>();

        public BlockNode(WasmType signature) {
            Signature = signature;
        }

        public WasmType Signature { get; }

        public override WasmType ResultType {
            get {
                WasmType? result = null;
                foreach (var node in Nodes) {
                    var nodeResult = node.ResultType;
                    if (result == null) {
                        if (nodeResult != WasmType.BlockType) {
                            result = nodeResult;
                        }
                    } else {
                        if (nodeResult != WasmType.BlockType) {
                            throw new WasmNodeException("multiple returns in block node");
                        }
                    }
                }
                return result ?? WasmType.BlockType;
            }
        }

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
