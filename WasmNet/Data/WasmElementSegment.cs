using System.Collections.Generic;

namespace WasmNet.Data {
    public class WasmElementSegment {

        public uint Index { get; set; }

        public WasmInitExpression Offset { get; set; }

        public IList<uint> Functions { get; } = new List<uint>();

    }
}
