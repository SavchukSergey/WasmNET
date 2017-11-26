namespace WasmNet.Data {
    public class WasmExportEntry {

        public string Field { get; set; }

        public WasmExternalKind Kind { get; set; }

        public uint Index { get; set; }

        public override string ToString() => $"(export \"{Field}\" {Kind}: {Index})";

    }
}
