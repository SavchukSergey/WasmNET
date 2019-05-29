namespace WasmNet.Runtime {
    public class WasmModuleInstance {

        public WasmModuleExports Exports { get; }

        public WasmModule Module { get; }

        public WasmModuleInstance(WasmModule module) {
            Module = module;
            Exports = new WasmModuleExports(this);
        }

    }
}
