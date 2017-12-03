using WasmNet.Data;

namespace WasmNet {
    public class WasmVariable {

        public WasmType Type { get; set; }

        public uint UInt32 { get; set; }

        public ulong UInt64 { get; set; }

        public float Float32 { get; set; }

        public double Float64 { get; set; }

    }
}
