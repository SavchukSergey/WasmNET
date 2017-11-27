namespace WasmNet.Nodes {
    public class WasmNodeContext {

        public ModuleNode Module { get; set; }

        public GlobalNode ResolveGlobal(uint globalIndex) {
            return Module.ResolveGlobal(globalIndex);
        }

        public FunctionNode ResolveFunction(uint functionIndex) {
            return Module.ResolveFunction(functionIndex);
        }

    }
}
