﻿namespace WasmNet.Opcodes {
    public enum WasmOpcodeType {
        Unreachable = 0x00,
        Nop = 0x01,
        Block = 0x02,
        Loop = 0x03,
        If = 0x04,
        Else = 0x05,
        End = 0x0b,
        Br = 0x0c,
        BrIf = 0x0d,
        Return = 0x0f,

        Call = 0x10,
        CallIndirect = 0x11,

        Drop = 0x1a,

        GetLocal = 0x20,
        SetLocal = 0x21,
        TeeLocal = 0x22,
        GetGlobal = 0x23,
        SetGlobal = 0x24,

        I32Load = 0x28,
        I64Load = 0x29,
        I32Load8S = 0x2c,
        I32Load8U = 0x2d,
        I32Store = 0x36,
        I64Store = 0x37,
        I32Store8 = 0x3a,
        I64Store32 = 0x3e,

        I32Const = 0x41,
        I64Const = 0x42,

        I32Eqz = 0x45,
        I32Eq = 0x46,
        I32Ne = 0x47,
        I32Lts = 0x48,
        I32Ltu = 0x49,
        I32Gts = 0x4a,
        I32Les = 0x4c,

        I64Eq = 0x51,
        I64Gtu = 0x56,
        I64Geu = 0x5a,

        I32Add = 0x6a,
        I32Sub = 0x6b,
        I32Divs = 0x6d,
        I32And = 0x71,
        I32Or = 0x72,
        I32Xor = 0x73,
        I32Shl = 0x74,
        I32ShrS = 0x75,
        I32ShrU = 0x76,

        I64Add = 0x7c,
        I64Sub = 0x7d,
        I64And = 0x83,
        I64Xor = 0x85,
        I64Shl = 0x86,
        I64ShrU = 0x88,

        I32WrapI64 = 0xa7,
        I64ExtendSI32 = 0xac,
        I64ExtendUI32 = 0xad
    }
}
