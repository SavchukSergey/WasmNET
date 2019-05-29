namespace WasmNet.Data {
    public enum WasmType : byte {
        I32 = 0x7f,
        I64 = 0x7e,
        F32 = 0x7d,
        F64 = 0x7c,
        Anyfunc = 0x70,
        Func = 0x60,
        BlockType = 0x40
    }

    public enum WasmBlockType {
        I32 = 0x7f,
        I64 = 0x7e,
        F32 = 0x7d,
        F64 = 0x7c,
        Void = 0x40,
    }
}
