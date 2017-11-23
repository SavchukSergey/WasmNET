using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmFunctionSection {

        public IList<uint> Entries { get; set; } = new List<uint>();

    }
}
