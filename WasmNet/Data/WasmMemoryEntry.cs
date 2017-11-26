namespace WasmNet.Data {
    public class WasmMemoryEntry {

        public WasmResizableLimits Limits { get; set; }

        public override string ToString() => $"(memory {Limits.Initial} {Limits.Maximum})";

    }
}
