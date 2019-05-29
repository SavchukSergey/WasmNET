using WasmNet.Data;

namespace WasmNet.Runtime {
    public class WasmVariable {

        public WasmType Type { get; set; }

        public uint UInt32 { get; set; }

        public ulong UInt64 { get; set; }

        public float Float32 { get; set; }

        public double Float64 { get; set; }

        public void SetUI32(uint value) {
            UInt32 = value;
            Type = WasmType.I32;
        }

    }
}
