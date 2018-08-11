namespace WasmNet {
    public class WasmModuleExports {

        private readonly  WasmModuleInstance _instance;
        
        public WasmModuleExports(WasmModuleInstance instance) {
            _instance = instance;
        }

        public object Execute(string exportName, params object[] args) {
            return 0;
        }

    }
}
