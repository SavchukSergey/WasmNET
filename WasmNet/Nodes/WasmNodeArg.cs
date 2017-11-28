﻿using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private Stack<BlockNode> Blocks { get; } = new Stack<BlockNode>();

        private BlockNode Current => Blocks.Peek();

        public WasmNodeContext Context { get; set; }

        public void PushBlock(BlockNode node) {
            Blocks.Push(node);
        }

        public BlockNode PopBlock() {
            return Blocks.Pop();
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

        public GlobalNode ResolveGlobal(uint index) {
            return Context.ResolveGlobal(index);
        }

        public virtual LocalNode ResolveLocal(uint index) {
            throw new WasmNodeException("Local variables are not accessinble in current context");
        }

    }
}
