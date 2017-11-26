namespace WasmNet.Data {
    public class WasmGlobalEntry {

        public WasmGlobalType Type { get; set; }

        public WasmInitExpression Init { get; internal set; }

    }
}
