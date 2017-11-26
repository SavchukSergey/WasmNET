using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmMemorySection {

        public IList<WasmMemoryEntry> Entries { get; } = new List<WasmMemoryEntry>();

    }
}
