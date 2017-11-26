using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmImportSection {

        public IList<WasmImportEntry> Entries { get; } = new List<WasmImportEntry>();

    }
}
