using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Nodes {
    public class WasmNodeContext {

        public ModuleNode Module { get; set; }

        public IList<WasmFunctionSignature> Types { get; } = new List<WasmFunctionSignature>();

        public GlobalNode ResolveGlobal(uint globalIndex) {
            return Module.ResolveGlobal(globalIndex);
        }

        public FunctionNode ResolveFunction(uint functionIndex) {
            return Module.ResolveFunction(functionIndex);
        }

        public WasmFunctionSignature ResolveType(uint typeIndex) {
            var index = typeIndex;
            if (index < Types.Count) return Types[(int)index];
            throw new WasmNodeException($"cannot resolve type with index {typeIndex}");
        }

    }
}
