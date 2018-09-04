using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private Stack<NodesList> Blocks { get; } = new Stack<NodesList>();

        private NodesList Current => Blocks.Peek();

        public WasmNodeContext Context { get; set; }

        public void PushBlock(NodesList node) {
            if (string.IsNullOrWhiteSpace(node.Label.Name)) {
                node.Label.Name = $"label_{Blocks.Count}";
            }
            Blocks.Push(node);
        }

        public NodesList PopBlock() {
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
            throw new WasmNodeException("Local variables are not accessible in current context");
        }

        public Label ResolveLabel(uint relativeDepth) {
            foreach (var block in Blocks) {
                if (relativeDepth == 0) return block.Label;
                relativeDepth--;
            }
            throw new WasmNodeException("unable to resolved label beyoud current nesting level");
        }

    }
}
