using System.Collections.Generic;

namespace WasmNet.Sections {
    public class WasmElementSection {

        public IList<WasmElementSegment> Entries { get; } = new List<WasmElementSegment>();

    }
}
