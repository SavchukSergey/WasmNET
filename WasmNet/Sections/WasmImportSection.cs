using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmImportSection {

        public IList<WasmImportEntry> Entries { get; } = new List<WasmImportEntry>();

    }
}
