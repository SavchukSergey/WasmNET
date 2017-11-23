using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmExportSection {

        public IList<WasmExportEntry> Entries { get; } = new List<WasmExportEntry>();

    }
}
