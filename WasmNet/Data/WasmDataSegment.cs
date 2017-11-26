namespace WasmNet.Data {
    public class WasmDataSegment {

        public uint Index { get; set; }

        public WasmInitExpression Offset { get; set; }

        public byte[] Data { get; set; }

    }
}
