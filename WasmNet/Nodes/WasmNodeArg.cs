using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private Stack<BlockNode> Blocks { get; } = new Stack<BlockNode>();

        private BlockNode Current => Blocks.Peek();

        public WasmNodeContext Context { get; set; }

        public FunctionNode Function { get; }

        public WasmNodeArg(FunctionNode function) {
            Function = function;
        }

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
            if (index < Function.Parameters.Count) return Function.Parameters[(int)index];
            index -= (uint)Function.Parameters.Count;
            if (index < Function.Variables.Count) return Function.Variables[(int)index];
            throw new WasmNodeException("Cannot resolve local variable");
        }

    }
}
