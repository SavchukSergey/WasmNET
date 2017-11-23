using System.Collections.Generic;

namespace WasmNet {
    public class WasmElementSegment {

        public uint Index { get; set; }

        public WasmInitExpression Offset { get; set; }

        public IList<uint> Functions { get; } = new List<uint>();

    }
}
