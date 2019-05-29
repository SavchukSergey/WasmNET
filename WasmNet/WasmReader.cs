using System;
using System.IO;
using System.Text;
using WasmNet.Data;
using WasmNet.Opcodes;
using WasmNet.Sections;

namespace WasmNet {
    public partial class WasmReader {

        private readonly BinaryReader _reader;

        public WasmReader(Stream stream) {
            _reader = new BinaryReader(stream, Encoding.UTF8, true);
        }

        public WasmReader(byte[] data) : this(new MemoryStream(data)) {
        }

        public WasmModule ReadModule() {
            var magic = ReadUInt32();
            if (magic != 0x6d736100) throw new WasmFormatException("invalid magic number");
            var module = new WasmModule {
                Version = ReadUInt32()
            };
            while (!Eof) {
                var section = ReadSection();
                module.AcceptSection(section);
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
            var flags = ReadVarUInt32();
            var offset = ReadVarUInt32();
            return new WasmMemoryImmediate(offset, flags);
        }

        public WasmLocalEntry ReadLocalEntry() {
            var count = ReadVarUInt32();
            var type = ReadValueType();
            return new WasmLocalEntry(type, count);
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

    }
}
