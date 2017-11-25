using System;
using System.IO;
using System.Text;
using WasmNet.Opcodes;
using WasmNet.Sections;

namespace WasmNet {
    public class WasmReader {

        private readonly BinaryReader _reader;

        public WasmReader(Stream stream) {
            _reader = new BinaryReader(stream, Encoding.UTF8, true);
        }

        public WasmReader(byte[] data) : this(new MemoryStream(data)) {
        }

        public byte ReadUInt8() {
            return _reader.ReadByte();
        }

        public ushort ReadUInt16() {
            return _reader.ReadUInt16();
        }

        public uint ReadUInt32() {
            return _reader.ReadUInt32();
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

        public WasmExternalKind ReadExternalKind() {
            return (WasmExternalKind)_reader.ReadByte();
        }

        public WasmSectionCode ReadSectionCode() {
            return (WasmSectionCode)_reader.ReadByte();
        }

        public WasmType ReadType() {
            return (WasmType)_reader.ReadByte();
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

        public WasmType ReadBlockType() {
            var type = ReadType();
            switch (type) {
                case WasmType.I32:
                case WasmType.I64:
                case WasmType.F32:
                case WasmType.F64:
                case WasmType.BlockType:
                    return type;
                default:
                    throw new WasmFormatException("block type expected");
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

        public WasmModule ReadModule() {
            var magic = ReadUInt32();
            if (magic != 0x6d736100) throw new WasmFormatException("invalid magic number");
            var module = new WasmModule {
                Version = ReadUInt32()
            };
            while (!Eof) {
                var section = ReadSection();
                module.Sections.Add(section);
            }
            return module;
        }

        public WasmSection ReadSection() {
            var code = ReadSectionCode();
            var payloadLength = ReadVarUInt32();
            var marker = Position;
            var name = code == WasmSectionCode.Custom ? ReadString() : null;
            var actualLength = payloadLength - (Position - marker);
            var payload = ReadBytes((uint)actualLength);
            return new WasmSection {
                Code = code,
                Name = name,
                Payload = payload
            };
        }

        public WasmResizableLimits ReadLimits() {
            var hasMaximum = ReadVarUInt1() != 0;
            var res = new WasmResizableLimits {
                Initial = ReadVarUInt32()
            };
            if (hasMaximum) {
                res.Maximum = ReadVarUInt32();
            }
            return res;
        }

        public WasmMemoryImmediate ReadMemoryImmediate() {
            return new WasmMemoryImmediate {
                Flags = ReadVarUInt32(),
                Offset = ReadVarUInt32()
            };
        }

        public WasmLocalEntry ReadLocalEntry() {
            return new WasmLocalEntry {
                Count = ReadVarUInt32(),
                Type = ReadValueType()
            };
        }

        public WasmInitExpression ReadInitExpression() {
            var res = new WasmInitExpression();
            BaseOpcode opcode;
            do {
                opcode = ReadOpcode();
                res.Opcodes.Add(opcode);
            } while (!(opcode is EndOpcode));
            return res;
        }

        public WasmFunctionSignature ReadFunctionSignature() {
            var type = ReadType();
            if (type != WasmType.Func) throw new WasmFormatException("func type expected");
            var paramCount = ReadVarUInt32();
            var res = new WasmFunctionSignature();
            for (var i = 0; i < paramCount; i++) {
                res.Parameters.Add(ReadValueType());
            }
            var returnCount = ReadVarUInt1();
            for (var i = 0; i < returnCount; i++) {
                res.Returns.Add(ReadValueType());
            }
            return res;
        }

        public WasmImportEntry ReadImportEntry() {
            var res = new WasmImportEntry {
                Module = ReadString(),
                Field = ReadString(),
                Kind = ReadExternalKind()
            };
            switch (res.Kind) {
                case WasmExternalKind.Function:
                    res.TypeIndex = ReadVarUInt32();
                    break;
                case WasmExternalKind.Global:
                    res.Global = ReadGlobalType();
                    break;
                case WasmExternalKind.Memory:
                    res.Memory = ReadMemoryEntry();
                    break;
                case WasmExternalKind.Table:
                    res.Table = ReadTableEntry();
                    break;
                default:
                    throw new NotSupportedException($"{res.Kind} import entry is not supported");
            }
            return res;
        }

        public WasmGlobalType ReadGlobalType() {
            return new WasmGlobalType {
                Type = ReadValueType(),
                Mutable = ReadVarUInt1() != 0
            };
        }

        public WasmGlobalEntry ReadGlobalEntry() {
            return new WasmGlobalEntry {
                Type = ReadGlobalType(),
                Init = ReadInitExpression()
            };
        }

        public WasmExportEntry ReadExportEntry() {
            return new WasmExportEntry {
                Field = ReadString(),
                Kind = ReadExternalKind(),
                Index = ReadVarUInt32()
            };
        }

        public WasmElementSegment ReadElementSegment() {
            var res = new WasmElementSegment {
                Index = ReadVarUInt32(),
                Offset = ReadInitExpression(),
            };
            var cnt = ReadVarUInt32();
            for (var i = 0; i < cnt; i++) {
                res.Functions.Add(ReadVarUInt32());
            }
            return res;
        }

        public WasmDataSegment ReadDataSegment() {
            var res = new WasmDataSegment {
                Index = ReadVarUInt32(),
                Offset = ReadInitExpression(),
            };
            var cnt = ReadVarUInt32();
            res.Data = ReadBytes(cnt);
            return res;
        }

        public WasmFunctionBody ReadFunctionBody() {
            var res = new WasmFunctionBody();
            var bodySize = ReadVarUInt32();
            var bodyBytes = ReadBytes(bodySize);
            var bodyReader = new WasmReader(bodyBytes);
            var locals = bodyReader.ReadVarUInt32();
            for (var i = 0; i < locals; i++) {
                res.Locals.Add(bodyReader.ReadLocalEntry());
            }
            while (!bodyReader.Eof) {
                res.Opcodes.Add(bodyReader.ReadOpcode());
            }
            return res;

        }

        public WasmMemoryEntry ReadMemoryEntry() {
            return new WasmMemoryEntry {
                Limits = ReadLimits()
            };
        }

        public WasmTableEntry ReadTableEntry() {
            return new WasmTableEntry {
                ElementType = ReadElementType(),
                Limits = ReadLimits()
            };
        }

        public WasmTypeSection ReadTypeSection() {
            var res = new WasmTypeSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var sig = ReadFunctionSignature();
                res.Entries.Add(sig);
            }
            return res;
        }

        public WasmImportSection ReadImportSection() {
            var res = new WasmImportSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadImportEntry();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmFunctionSection ReadFunctionSection() {
            var res = new WasmFunctionSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadVarUInt32();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmTableSection ReadTableSection() {
            var res = new WasmTableSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadTableEntry();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmMemorySection ReadMemorySection() {
            var res = new WasmMemorySection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadMemoryEntry();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmGlobalSection ReadGlobalSection() {
            var res = new WasmGlobalSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadGlobalEntry();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmExportSection ReadExportSection() {
            var res = new WasmExportSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadExportEntry();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmStartSection ReadStartSection() {
            return new WasmStartSection {
                Index = ReadUInt32()
            };
        }

        public WasmElementSection ReadElementSection() {
            var res = new WasmElementSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadElementSegment();
                res.Entries.Add(entry);
            }
            return res;
        }

        public WasmCodeSection ReadCodeSection() {
            var res = new WasmCodeSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadFunctionBody();
                res.Bodies.Add(entry);
            }
            return res;
        }

        public WasmDataSection ReadDataSection() {
            var res = new WasmDataSection();
            var count = ReadVarUInt32();
            for (var i = 0; i < count; i++) {
                var entry = ReadDataSegment();
                res.Entries.Add(entry);
            }
            return res;
        }

        public BaseOpcode ReadOpcode() {
            var type = ReadOpcodeType();
            switch (type) {
                case WasmOpcodeType.Unreachable: return new UnreachableOpcode();
                case WasmOpcodeType.Nop: return new NopOpcode();
                case WasmOpcodeType.Block: return new BlockOpcode { Signature = ReadBlockType() };
                case WasmOpcodeType.Loop: return new LoopOpcode { Signature = ReadBlockType() };
                case WasmOpcodeType.If: return new IfOpcode { Signature = ReadBlockType() };
                case WasmOpcodeType.Else: return new ElseOpcode();
                case WasmOpcodeType.End: return new EndOpcode();
                case WasmOpcodeType.Br: return new BrOpcode { RelativeDepth = ReadVarUInt32() };
                case WasmOpcodeType.BrIf: return new BrIfOpcode { RelativeDepth = ReadVarUInt32() };
                case WasmOpcodeType.BrTable:
                    var res = new BrTableOpcode();
                    var cnt = ReadVarUInt32();
                    for (var i = 0; i < cnt; i++) {
                        res.Targets.Add(ReadVarUInt32());
                    }
                    res.DefaultTarget = ReadVarUInt32();
                    return res;

                case WasmOpcodeType.Return: return new ReturnOpcode();

                case WasmOpcodeType.Call: return new CallOpcode { FunctionIndex = ReadVarUInt32() };
                case WasmOpcodeType.CallIndirect: return new CallIndirectOpcode { TypeIndex = ReadVarUInt32(), Reserved = ReadVarUInt1() };
                case WasmOpcodeType.Drop: return new DropOpcode();

                case WasmOpcodeType.GetLocal: return new GetLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.SetLocal: return new SetLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.TeeLocal: return new TeeLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.GetGlobal: return new GetGlobalOpcode { GlobalIndex = ReadVarUInt32() };
                case WasmOpcodeType.SetGlobal: return new SetGlobalOpcode { GlobalIndex = ReadVarUInt32() };

                case WasmOpcodeType.I32Load: return new I32LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load: return new I64LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load8S: return new I32Load8SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load8U: return new I32Load8UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load16S: return new I32Load16SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load16U: return new I32Load16UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Store: return new I32StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store: return new I64StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Store8: return new I32Store8Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Store16: return new I32Store16Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store8: return new I64Store8Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store32: return new I64Store32Opcode { Address = ReadMemoryImmediate() };

                case WasmOpcodeType.I32Const: return new I32ConstOpcode { Value = ReadVarInt32() };
                case WasmOpcodeType.I64Const: return new I64ConstOpcode { Value = ReadVarInt64() };

                case WasmOpcodeType.I32Eqz: return new I32EqzOpcode();
                case WasmOpcodeType.I32Eq: return new I32EqOpcode();
                case WasmOpcodeType.I32Ne: return new I32NeOpcode();
                case WasmOpcodeType.I32Lts: return new I32LtsOpcode();
                case WasmOpcodeType.I32Ltu: return new I32LtuOpcode();
                case WasmOpcodeType.I32Gts: return new I32GtsOpcode();
                case WasmOpcodeType.I32Gtu: return new I32GtuOpcode();
                case WasmOpcodeType.I32Les: return new I32LesOpcode();
                case WasmOpcodeType.I32Leu: return new I32LeuOpcode();
                case WasmOpcodeType.I32Ges: return new I32GesOpcode();
                case WasmOpcodeType.I32Geu: return new I32GeuOpcode();

                case WasmOpcodeType.I64Eqz: return new I64EqzOpcode();
                case WasmOpcodeType.I64Eq: return new I64EqOpcode();
                case WasmOpcodeType.I64Ne: return new I64NeOpcode();
                case WasmOpcodeType.I64Lts: return new I64LtsOpcode();
                case WasmOpcodeType.I64Ltu: return new I64LtuOpcode();
                case WasmOpcodeType.I64Gts: return new I64GtsOpcode();
                case WasmOpcodeType.I64Gtu: return new I64GtuOpcode();
                case WasmOpcodeType.I64Les: return new I64LesOpcode();
                case WasmOpcodeType.I64Leu: return new I64LeuOpcode();
                case WasmOpcodeType.I64Ges: return new I64GesOpcode();
                case WasmOpcodeType.I64Geu: return new I64GeuOpcode();

                case WasmOpcodeType.F32Eq: return new F32EqOpcode();
                case WasmOpcodeType.F32Ne: return new F32NeOpcode();
                case WasmOpcodeType.F32Lt: return new F32LtOpcode();
                case WasmOpcodeType.F32Gt: return new F32GtOpcode();
                case WasmOpcodeType.F32Le: return new F32LeOpcode();
                case WasmOpcodeType.F32Ge: return new F32GeOpcode();

                case WasmOpcodeType.F64Eq: return new F64EqOpcode();
                case WasmOpcodeType.F64Ne: return new F64NeOpcode();
                case WasmOpcodeType.F64Lt: return new F64LtOpcode();
                case WasmOpcodeType.F64Gt: return new F64GtOpcode();
                case WasmOpcodeType.F64Le: return new F64LeOpcode();
                case WasmOpcodeType.F64Ge: return new F64GeOpcode();

                case WasmOpcodeType.I32Add: return new I32AddOpcode();
                case WasmOpcodeType.I32Sub: return new I32SubOpcode();
                case WasmOpcodeType.I32Mul: return new I32MulOpcode();
                case WasmOpcodeType.I32Divs: return new I32DivsOpcode();
                case WasmOpcodeType.I32Divu: return new I32DivuOpcode();
                case WasmOpcodeType.I32RemU: return new I32RemUOpcode();
                case WasmOpcodeType.I32And: return new I32AndOpcode();
                case WasmOpcodeType.I32Or: return new I32OrOpcode();
                case WasmOpcodeType.I32Xor: return new I32XorOpcode();
                case WasmOpcodeType.I32Shl: return new I32ShlOpcode();
                case WasmOpcodeType.I32ShrS: return new I32ShrSOpcode();
                case WasmOpcodeType.I32ShrU: return new I32ShrUOpcode();

                case WasmOpcodeType.I64Add: return new I64AddOpcode();
                case WasmOpcodeType.I64Sub: return new I64SubOpcode();
                case WasmOpcodeType.I64Mul: return new I64MulOpcode();
                case WasmOpcodeType.I64And: return new I64AndOpcode();
                case WasmOpcodeType.I64Or: return new I64OrOpcode();
                case WasmOpcodeType.I64Xor: return new I64XorOpcode();
                case WasmOpcodeType.I64Shl: return new I64ShlOpcode();
                case WasmOpcodeType.I64ShrU: return new I64ShrUOpcode();

                case WasmOpcodeType.I32WrapI64: return new I32WrapI64Opcode();
                case WasmOpcodeType.I64ExtendSI32: return new I64ExtendSI32Opcode();
                case WasmOpcodeType.I64ExtendUI32: return new I64ExtendUI32Opcode();

                default: throw new WasmFormatException($"unknown opcode 0x{(byte)type:x2}");
            }
        }

    }
}
