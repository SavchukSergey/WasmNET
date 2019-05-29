namespace WasmNet.Data {
    public class WasmLocalEntry {

        public WasmLocalEntry(WasmType type, uint count) {
            Type = type;
            Count = count;
        }

        public uint Count { get; }

        public WasmType Type { get; }

    }
}
