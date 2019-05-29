using System;
using System.Text;
using WasmNet.Data;
using WasmNet.Opcodes;

namespace WasmNet {
    public partial class WasmReader {

        public byte ReadUInt8() {
            return _reader.ReadByte();
        }

        public ushort ReadUInt16() {
            return _reader.ReadUInt16();
        }

        public uint ReadUInt32() {
            return _reader.ReadUInt32();
        }

        public ulong ReadUInt64() {
            return _reader.ReadUInt64();
        }

        public byte ReadVarUInt1() {
            return _reader.ReadByte();
        }

        public uint ReadVarUInt7() {
            var bt = _reader.ReadByte();
            if (bt >= 0x80) throw new WasmFormatException("varuint7 overflow");
            return bt;
        }

        public uint ReadVarUInt32() {
            var res = 0u;
            var pos = 0;
            byte bt;
            do {
                bt = _reader.ReadByte();
                res |= ((uint)(bt & 0x7f) << pos);
                pos += 7;
            } while (bt >= 0x80);
            return res;
        }

        public sbyte ReadVarInt7() {
            var bt = _reader.ReadByte();
            if (bt >= 0x80) throw new WasmFormatException("varuint7 overflow");
            return (sbyte)(bt & 0x80);
        }

        public int ReadVarInt32() {
            var res = 0u;
            var pos = 0;
            byte bt;
            do {
                bt = _reader.ReadByte();
                res |= ((uint)(bt & 0x7f) << pos);
                pos += 7;
                if ((bt & 0xff) == 0x40) res |= (~0u << pos);
            } while (bt >= 0x80);
            return (int)res;
        }

        public long ReadVarInt64() {
            var res = 0ul;
            var pos = 0;
            byte bt;
            do {
                bt = _reader.ReadByte();
                res |= ((ulong)(bt & 0x7f) << pos);
                pos += 7;
                if ((bt & 0xff) == 0x40) res |= (~0ul << pos);
            } while (bt >= 0x80);
            return (long)res;
        }

        public float ReadF32() {
            var val = ReadUInt32();
            return BitConverter.Int32BitsToSingle((int)val);
        }

        public double ReadF64() {
            var val = ReadUInt64();
            return BitConverter.Int64BitsToDouble((long)val);
        }

        public WasmExternalKind ReadExternalKind() {
            return (WasmExternalKind)_reader.ReadByte();
        }

        public WasmSectionCode ReadSectionCode() {
            return (WasmSectionCode)_reader.ReadByte();
        }

        public WasmType ReadType() {
            return (WasmType)_reader.ReadByte();
        }

        public WasmBlockType ReadBlockType() {
            return (WasmBlockType)_reader.ReadByte();
        }

        public WasmOpcodeType ReadOpcodeType() {
            return (WasmOpcodeType)_reader.ReadByte();
        }

        public WasmType ReadValueType() {
            var type = ReadType();
            switch (type) {
                case WasmType.I32:
                case WasmType.I64:
                case WasmType.F32:
                case WasmType.F64:
                    return type;
                default:
                    throw new WasmFormatException("value type expected");
            }
        }

        public WasmType ReadElementType() {
            var type = ReadType();
            switch (type) {
                case WasmType.Anyfunc:
                    return type;
                default:
                    throw new WasmFormatException("element type expected");
            }
        }

        public string ReadString() {
            var len = ReadVarUInt32();
            var bytes = ReadBytes(len);
            return Encoding.UTF8.GetString(bytes);
        }

        public byte[] ReadBytes(uint length) {
            return _reader.ReadBytes((int)length);
        }

        public bool Eof => Position == _reader.BaseStream.Length;

        public long Position => _reader.BaseStream.Position;
    }
}
