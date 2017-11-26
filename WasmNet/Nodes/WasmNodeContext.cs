using System.Collections.Generic;

namespace WasmNet.Nodes {
    public class WasmNodeContext {

        public IList<FunctionNode> Functions { get; } = new List<FunctionNode>();

        public IList<FunctionNode> ImportedFunctions { get; } = new List<FunctionNode>();

        public FunctionNode ResolveFunction(uint functionIndex) {
            if (functionIndex < ImportedFunctions.Count) return ImportedFunctions[(int)functionIndex];
            functionIndex -= (uint)ImportedFunctions.Count;
            if (functionIndex < Functions.Count) return Functions[(int)functionIndex];
            throw new WasmNodeException($"cannot resolve function with index {functionIndex}");
        }

    }
}
