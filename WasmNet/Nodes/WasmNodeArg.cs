using System;
using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class WasmNodeArg {

        private BlockNode _mainBlock = new BlockNode();

        public Stack<BaseNode> Stack { get; } = new Stack<BaseNode>();

        public Stack<BlockNode> Blocks { get; } = new Stack<BlockNode>();

        public BlockNode Execution => Blocks.Count > 0 ? Blocks.Peek() : _mainBlock;

        public WasmNodeContext Context { get; set; }

        public FunctionNode Function { get; set; }

        public WasmNodeArg() {
            Blocks.Push(_mainBlock);
        }

        public void PushBlock(WasmType signature) {
            Blocks.Push(new BlockNode());
        }

        public void PopBlock() {
            Blocks.Pop();
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
