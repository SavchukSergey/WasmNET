using System;
using System.IO;
using System.Text;
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
                case WasmOpcodeType.Select: return new SelectOpcode();

                case WasmOpcodeType.GetLocal: return new GetLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.SetLocal: return new SetLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.TeeLocal: return new TeeLocalOpcode { LocalIndex = ReadVarUInt32() };
                case WasmOpcodeType.GetGlobal: return new GetGlobalOpcode { GlobalIndex = ReadVarUInt32() };
                case WasmOpcodeType.SetGlobal: return new SetGlobalOpcode { GlobalIndex = ReadVarUInt32() };

                case WasmOpcodeType.I32Load: return new I32LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load: return new I64LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.F32Load: return new F32LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.F64Load: return new F64LoadOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load8S: return new I32Load8SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load8U: return new I32Load8UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load16S: return new I32Load16SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Load16U: return new I32Load16UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load8S: return new I64Load8SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load8U: return new I64Load8UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load16S: return new I64Load16SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load16U: return new I64Load16UOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load32S: return new I64Load32SOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Load32U: return new I64Load32UOpcode { Address = ReadMemoryImmediate() };

                case WasmOpcodeType.I32Store: return new I32StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store: return new I64StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.F32Store: return new F32StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.F64Store: return new F64StoreOpcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Store8: return new I32Store8Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I32Store16: return new I32Store16Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store8: return new I64Store8Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store16: return new I64Store16Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.I64Store32: return new I64Store32Opcode { Address = ReadMemoryImmediate() };
                case WasmOpcodeType.CurrentMemory: return new CurrentMemoryOpcode { Reserved = ReadVarUInt1() };
                case WasmOpcodeType.GrowMemory: return new GrowMemoryOpcode { Reserved = ReadVarUInt1() };

                case WasmOpcodeType.I32Const: return new I32ConstOpcode { Value = ReadVarInt32() };
                case WasmOpcodeType.I64Const: return new I64ConstOpcode { Value = ReadVarInt64() };
                case WasmOpcodeType.F32Const: return new F32ConstOpcode { Value = ReadF32() };
                case WasmOpcodeType.F64Const: return new F64ConstOpcode { Value = ReadF64() };

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

                case WasmOpcodeType.I32Clz: return new I32ClzOpcode();
                case WasmOpcodeType.I32Ctz: return new I32CtzOpcode();
                case WasmOpcodeType.I32PopCnt: return new I32PopCntOpcode();
                case WasmOpcodeType.I32Add: return new I32AddOpcode();
                case WasmOpcodeType.I32Sub: return new I32SubOpcode();
                case WasmOpcodeType.I32Mul: return new I32MulOpcode();
                case WasmOpcodeType.I32DivS: return new I32DivSOpcode();
                case WasmOpcodeType.I32DivU: return new I32DivUOpcode();
                case WasmOpcodeType.I32RemS: return new I32RemSOpcode();
                case WasmOpcodeType.I32RemU: return new I32RemUOpcode();
                case WasmOpcodeType.I32And: return new I32AndOpcode();
                case WasmOpcodeType.I32Or: return new I32OrOpcode();
                case WasmOpcodeType.I32Xor: return new I32XorOpcode();
                case WasmOpcodeType.I32Shl: return new I32ShlOpcode();
                case WasmOpcodeType.I32ShrS: return new I32ShrSOpcode();
                case WasmOpcodeType.I32ShrU: return new I32ShrUOpcode();
                case WasmOpcodeType.I32Rotl: return new I32RotlOpcode();
                case WasmOpcodeType.I32Rotr: return new I32RotrOpcode();

                case WasmOpcodeType.I64Clz: return new I64ClzOpcode();
                case WasmOpcodeType.I64Ctz: return new I64CtzOpcode();
                case WasmOpcodeType.I64PopCnt: return new I64PopCntOpcode();
                case WasmOpcodeType.I64Add: return new I64AddOpcode();
                case WasmOpcodeType.I64Sub: return new I64SubOpcode();
                case WasmOpcodeType.I64Mul: return new I64MulOpcode();
                case WasmOpcodeType.I64DivS: return new I64DivSOpcode();
                case WasmOpcodeType.I64DivU: return new I64DivUOpcode();
                case WasmOpcodeType.I64RemS: return new I64RemSOpcode();
                case WasmOpcodeType.I64RemU: return new I64RemUOpcode();
                case WasmOpcodeType.I64And: return new I64AndOpcode();
                case WasmOpcodeType.I64Or: return new I64OrOpcode();
                case WasmOpcodeType.I64Xor: return new I64XorOpcode();
                case WasmOpcodeType.I64Shl: return new I64ShlOpcode();
                case WasmOpcodeType.I64ShrS: return new I64ShrSOpcode();
                case WasmOpcodeType.I64ShrU: return new I64ShrUOpcode();
                case WasmOpcodeType.I64Rotl: return new I64RotlOpcode();
                case WasmOpcodeType.I64Rotr: return new I64RotrOpcode();

                case WasmOpcodeType.F32Abs: return new F32AbsOpcode();
                case WasmOpcodeType.F32Neg: return new F32NegOpcode();
                case WasmOpcodeType.F32Ceil: return new F32CeilOpcode();
                case WasmOpcodeType.F32Floor: return new F32FloorOpcode();
                case WasmOpcodeType.F32Trunc: return new F32TruncOpcode();
                case WasmOpcodeType.F32Nearest: return new F32NearestOpcode();
                case WasmOpcodeType.F32Sqrt: return new F32SqrtOpcode();
                case WasmOpcodeType.F32Add: return new F32AddOpcode();
                case WasmOpcodeType.F32Sub: return new F32SubOpcode();
                case WasmOpcodeType.F32Mul: return new F32MulOpcode();
                case WasmOpcodeType.F32Div: return new F32DivOpcode();
                case WasmOpcodeType.F32Min: return new F32MinOpcode();
                case WasmOpcodeType.F32Max: return new F32MaxOpcode();
                case WasmOpcodeType.F32CopySign: return new F32CopySignOpcode();

                case WasmOpcodeType.F64Abs: return new F64AbsOpcode();
                case WasmOpcodeType.F64Neg: return new F64NegOpcode();
                case WasmOpcodeType.F64Ceil: return new F64CeilOpcode();
                case WasmOpcodeType.F64Floor: return new F64FloorOpcode();
                case WasmOpcodeType.F64Trunc: return new F64TruncOpcode();
                case WasmOpcodeType.F64Nearest: return new F64NearestOpcode();
                case WasmOpcodeType.F64Sqrt: return new F64SqrtOpcode();
                case WasmOpcodeType.F64Add: return new F64AddOpcode();
                case WasmOpcodeType.F64Sub: return new F64SubOpcode();
                case WasmOpcodeType.F64Mul: return new F64MulOpcode();
                case WasmOpcodeType.F64Div: return new F64DivOpcode();
                case WasmOpcodeType.F64Min: return new F64MinOpcode();
                case WasmOpcodeType.F64Max: return new F64MaxOpcode();
                case WasmOpcodeType.F64CopySign: return new F64CopySignOpcode();

                case WasmOpcodeType.I32WrapI64: return new I32WrapI64Opcode();
                case WasmOpcodeType.I32TruncSF32: return new I32TruncSF32Opcode();
                case WasmOpcodeType.I32TruncUF32: return new I32TruncUF32Opcode();
                case WasmOpcodeType.I32TruncSF64: return new I32TruncSF64Opcode();
                case WasmOpcodeType.I32TruncUF64: return new I32TruncUF64Opcode();
                case WasmOpcodeType.I64ExtendSI32: return new I64ExtendSI32Opcode();
                case WasmOpcodeType.I64ExtendUI32: return new I64ExtendUI32Opcode();
                case WasmOpcodeType.I64TruncSF32: return new I64TruncSF32Opcode();
                case WasmOpcodeType.I64TruncUF32: return new I64TruncUF32Opcode();
                case WasmOpcodeType.I64TruncSF64: return new I64TruncSF64Opcode();
                case WasmOpcodeType.I64TruncUF64: return new I64TruncUF64Opcode();
                case WasmOpcodeType.F32ConvertSI32: return new F32ConvertSI32Opcode();
                case WasmOpcodeType.F32ConvertUI32: return new F32ConvertUI32Opcode();
                case WasmOpcodeType.F32ConvertSI64: return new F32ConvertSI64Opcode();
                case WasmOpcodeType.F32ConvertUI64: return new F32ConvertUI64Opcode();
                case WasmOpcodeType.F32DemoteF64: return new F32DemoteF64Opcode();
                case WasmOpcodeType.F64ConvertSI32: return new F64ConvertSI32Opcode();
                case WasmOpcodeType.F64ConvertUI32: return new F64ConvertUI32Opcode();
                case WasmOpcodeType.F64ConvertSI64: return new F64ConvertSI64Opcode();
                case WasmOpcodeType.F64ConvertUI64: return new F64ConvertUI64Opcode();
                case WasmOpcodeType.F64PromoteF32: return new F64PromoteF32Opcode();

                case WasmOpcodeType.I32ReinterpretF32: return new I32ReinterpretF32Opcode();
                case WasmOpcodeType.I64ReinterpretF64: return new I64ReinterpretF64Opcode();
                case WasmOpcodeType.F32ReinterpretI32: return new F32ReinterpretI32Opcode();
                case WasmOpcodeType.F64ReinterpretI64: return new F64ReinterpretI64Opcode();

                default: throw new WasmFormatException($"unknown opcode 0x{(byte)type:x2}");
            }
        }

    }
}
