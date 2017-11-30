using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private Stack<BlockNode> Blocks { get; } = new Stack<BlockNode>();

        private BlockNode Current => Blocks.Peek();

        public WasmNodeContext Context { get; set; }

        public void PushBlock(BlockNode node) {
            Blocks.Push(node);
        }

        public BlockNode PopBlock() {
            var node = Blocks.Pop();
            //if (node.Signature != null) {
            //    var actualResult = node.ResultType;
            //    if (actualResult != node.Signature) throw new WasmNodeException($"cannot assign {actualResult} block to {node.Signature} block");
            //}
            return node;
        }

        public bool HasBlock {
            get {
                return Blocks.Count > 0;
            }
        }

        public void Push(ExecutableNode node) {
            Current.Push(node);
        }

        public ExecutableNode Pop() {
            return Current.Pop();
        }

        public GlobalNode ResolveGlobal(uint index) {
            return Context.ResolveGlobal(index);
        }

        public virtual LocalNode ResolveLocal(uint index) {
            throw new WasmNodeException("Local variables are not accessinble in current context");
        }

    }
}
