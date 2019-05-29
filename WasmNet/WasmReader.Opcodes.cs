using System.Collections.Generic;
using WasmNet.Opcodes;

namespace WasmNet {
    public partial class WasmReader {

        public BaseOpcode ReadOpcode() {
            var type = ReadOpcodeType();
            switch (type) {
                case WasmOpcodeType.Unreachable: return new UnreachableOpcode();
                case WasmOpcodeType.Nop: return new NopOpcode();
                case WasmOpcodeType.Block: return new BlockOpcode(ReadBlockType());
                case WasmOpcodeType.Loop: return new LoopOpcode(ReadBlockType());
                case WasmOpcodeType.If: return new IfOpcode(ReadBlockType());
                case WasmOpcodeType.Else: return new ElseOpcode();
                case WasmOpcodeType.End: return new EndOpcode();
                case WasmOpcodeType.Br: return new BrOpcode(ReadVarUInt32());
                case WasmOpcodeType.BrIf: return new BrIfOpcode(ReadVarUInt32());
                case WasmOpcodeType.BrTable:
                    var cnt = ReadVarUInt32();
                    var targets = new List<uint>((int)cnt);
                    for (var i = 0; i < cnt; i++) {
                        targets.Add(ReadVarUInt32());
                    }
                    var defaultTarget = ReadVarUInt32();
                    var res = new BrTableOpcode(defaultTarget, targets);
                    return res;

                case WasmOpcodeType.Return: return new ReturnOpcode();

                case WasmOpcodeType.Call: return new CallOpcode(ReadVarUInt32());
                case WasmOpcodeType.CallIndirect: return new CallIndirectOpcode(ReadVarUInt32(), ReadVarUInt1());

                case WasmOpcodeType.Drop: return new DropOpcode();
                case WasmOpcodeType.Select: return new SelectOpcode();

                case WasmOpcodeType.LocalGet: return new LocalGetOpcode(ReadVarUInt32());
                case WasmOpcodeType.LocalSet: return new LocalSetOpcode(ReadVarUInt32());
                case WasmOpcodeType.LocalTee: return new LocalTeeOpcode(ReadVarUInt32());
                case WasmOpcodeType.GlobalGet: return new GlobalGetOpcode(ReadVarUInt32());
                case WasmOpcodeType.GlobalSet: return new GlobalSetOpcode(ReadVarUInt32());

                case WasmOpcodeType.I32Load: return new I32LoadOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load: return new I64LoadOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.F32Load: return new F32LoadOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.F64Load: return new F64LoadOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Load8S: return new I32Load8SOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Load8U: return new I32Load8UOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Load16S: return new I32Load16SOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Load16U: return new I32Load16UOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load8S: return new I64Load8SOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load8U: return new I64Load8UOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load16S: return new I64Load16SOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load16U: return new I64Load16UOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load32S: return new I64Load32SOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Load32U: return new I64Load32UOpcode(ReadMemoryImmediate());

                case WasmOpcodeType.I32Store: return new I32StoreOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Store: return new I64StoreOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.F32Store: return new F32StoreOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.F64Store: return new F64StoreOpcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Store8: return new I32Store8Opcode(ReadMemoryImmediate());
                case WasmOpcodeType.I32Store16: return new I32Store16Opcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Store8: return new I64Store8Opcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Store16: return new I64Store16Opcode(ReadMemoryImmediate());
                case WasmOpcodeType.I64Store32: return new I64Store32Opcode(ReadMemoryImmediate());
                case WasmOpcodeType.CurrentMemory: return new MemorySizeOpcode(ReadVarUInt1());
                case WasmOpcodeType.GrowMemory: return new MemoryGrowOpcode(ReadVarUInt1());

                case WasmOpcodeType.I32Const: return new I32ConstOpcode(ReadVarInt32());
                case WasmOpcodeType.I64Const: return new I64ConstOpcode(ReadVarInt64());
                case WasmOpcodeType.F32Const: return new F32ConstOpcode(ReadF32());
                case WasmOpcodeType.F64Const: return new F64ConstOpcode(ReadF64());

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
                case WasmOpcodeType.I32TruncF32S: return new I32TruncF32SOpcode();
                case WasmOpcodeType.I32TruncF32U: return new I32TruncF32UOpcode();
                case WasmOpcodeType.I32TruncF64S: return new I32TruncF64SOpcode();
                case WasmOpcodeType.I32TruncF64U: return new I32TruncF64UOpcode();
                case WasmOpcodeType.I64ExtendI32S: return new I64ExtendI32SOpcode();
                case WasmOpcodeType.I64ExtendI32U: return new I64ExtendI32UOpcode();
                case WasmOpcodeType.I64TruncF32S: return new I64TruncF32SOpcode();
                case WasmOpcodeType.I64TruncF32U: return new I64TruncF32UOpcode();
                case WasmOpcodeType.I64TruncF64S: return new I64TruncF64SOpcode();
                case WasmOpcodeType.I64TruncF64U: return new I64TruncF64UOpcode();
                case WasmOpcodeType.F32ConvertI32S: return new F32ConvertI32SOpcode();
                case WasmOpcodeType.F32ConvertI32U: return new F32ConvertI32UOpcode();
                case WasmOpcodeType.F32ConvertI64S: return new F32ConvertI64SOpcode();
                case WasmOpcodeType.F32ConvertI64U: return new F32ConvertI64UOpcode();
                case WasmOpcodeType.F32DemoteF64: return new F32DemoteF64Opcode();
                case WasmOpcodeType.F64ConvertI32S: return new F64ConvertI32SOpcode();
                case WasmOpcodeType.F64ConvertI32U: return new F64ConvertI32UOpcode();
                case WasmOpcodeType.F64ConvertI64S: return new F64ConvertI64SOpcode();
                case WasmOpcodeType.F64ConvertI64U: return new F64ConvertI64UOpcode();
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
