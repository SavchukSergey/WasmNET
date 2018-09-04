namespace WasmNet.Nodes {
    public class WasmFunctionNodeArg : WasmNodeArg {

        public FunctionNode Function { get; }

        public WasmFunctionNodeArg(FunctionNode function) {
            Function = function;
        }

        public override LocalNode ResolveLocal(uint index) {
            if (index < Function.Parameters.Count) return Function.Parameters[(int)index];
            index -= (uint)Function.Parameters.Count;
            if (index < Function.Variables.Count) return Function.Variables[(int)index];
            throw new WasmNodeException("Cannot resolve local variable");
        }

    }
}
