using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmGlobalSection {

        public IList<WasmGlobalEntry> Entries { get; } = new List<WasmGlobalEntry>();

    }
}
