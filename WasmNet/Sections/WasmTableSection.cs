using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmTableSection {

        public IList<WasmTableEntry> Entries { get; } = new List<WasmTableEntry>();

    }
}
