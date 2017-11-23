using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmMemorySection {

        public IList<WasmMemoryEntry> Entries { get; } = new List<WasmMemoryEntry>();

    }
}
