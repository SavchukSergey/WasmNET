using System;
using WasmNet.Data;

namespace WasmNet {
    public class WasmMemory {

        public float ReadFloat32(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteFloat32(uint address, WasmMemoryImmediate immediate, float value) => throw new NotImplementedException();

        public double ReadFloat64(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteFloat64(uint address, WasmMemoryImmediate immediate, double value) => throw new NotImplementedException();

        public sbyte ReadSInt8(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public byte ReadUInt8(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteUInt8(uint address, WasmMemoryImmediate immediate, byte value) => throw new NotImplementedException();

        public short ReadSInt16(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public ushort ReadUInt16(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteUInt16(uint address, WasmMemoryImmediate immediate, ushort value) => throw new NotImplementedException();

        public int ReadSInt32(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public uint ReadUInt32(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteUInt32(uint address, WasmMemoryImmediate immediate, uint value) => throw new NotImplementedException();

        public ulong ReadUInt64(uint address, WasmMemoryImmediate immediate) => throw new NotImplementedException();

        public void WriteUInt64(uint address, WasmMemoryImmediate immediate, ulong value) => throw new NotImplementedException();

    }
}
