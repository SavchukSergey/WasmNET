namespace WasmNet.Opcodes {
    public enum WasmOpcodeType {
        Unreachable = 0x00,
        Nop = 0x01,
        Block = 0x02,
        If = 0x04,
        Else = 0x05,
        End = 0x0b,
        Call = 0x10,
        Drop = 0x1a,
        GetLocal = 0x20,
        SetLocal = 0x21,
        TeeLocal = 0x22,
        GetGlobal = 0x23,
        SetGlobal = 0x24,
        I32Load = 0x28,
        I32Store = 0x36,
        I32Const = 0x41,
        I32Eqz = 0x45,
        I32Add = 0x6a,
        I32And = 0x71,
        I32Shl = 0x74,
        I64ExtendUI32 = 0xad
    }
}
