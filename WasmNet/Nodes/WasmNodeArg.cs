using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private Stack<BlockNode> Blocks { get; } = new Stack<BlockNode>();

        private BlockNode Current => Blocks.Peek();

        public WasmNodeContext Context { get; set; }

        public FunctionNode Function { get; set; }

        public void PushBlock(BlockNode node) {
            Blocks.Push(node);
        }

        public void PopBlock() {
            Blocks.Pop();
        }

        public bool HasBlock {
            get {
                return Blocks.Count > 1;
            }
        }

        public void Push(BaseNode node) {
            Current.Push(node);
        }

        public BaseNode Pop() {
            return Current.Pop();
        }

        public GlobalVariable ResolveGlobal(uint index) {
            return new GlobalVariable {
                Name = $"global_{index}"
            };
        }

        public LocalVariable ResolveLocal(uint index) {
            return new LocalVariable {
                Name = $"local_{index}"
            };
        }

    }
}
