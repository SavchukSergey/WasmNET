using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmExportSection {

        public IList<WasmExportEntry> Entries { get; } = new List<WasmExportEntry>();

    }
}
