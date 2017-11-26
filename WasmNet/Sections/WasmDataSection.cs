using System.Collections.Generic;
using WasmNet.Data;

namespace WasmNet.Sections {
    public class WasmDataSection {

        public IList<WasmDataSegment> Entries { get; } = new List<WasmDataSegment>();

    }
}
