using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmTableSection {

        public IList<WasmTableEntry> Entries { get; } = new List<WasmTableEntry>();

    }
}
