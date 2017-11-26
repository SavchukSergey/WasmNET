using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmGlobalSection {

        public IList<WasmGlobalEntry> Entries { get; } = new List<WasmGlobalEntry>();

    }
}
