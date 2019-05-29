namespace WasmNet.Data {
    public class WasmMemoryImmediate {

        public WasmMemoryImmediate(uint offset, uint flags) {
            Offset = offset;
            Flags = flags;
        }

        public uint Flags { get; }

        public uint Offset { get; }

        public override string ToString() => $"offset={Offset}";

    }
}
