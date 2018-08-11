namespace WasmNet {
    public class WasmModuleInstance {

        public WasmModuleExports Exports { get; }

        public WasmModuleInstance() {
            Exports = new WasmModuleExports(this);
        }
        
    }
}
