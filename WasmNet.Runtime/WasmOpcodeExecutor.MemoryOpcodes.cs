using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(I32LoadOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt32(adr, opcode.Immediate);
            state.PushUI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Load8SOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt8(adr, opcode.Immediate);
            state.PushSI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Load8UOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt8(adr, opcode.Immediate);
            state.PushUI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Load16SOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt16(adr, opcode.Immediate);
            state.PushSI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Load16UOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt16(adr, opcode.Immediate);
            state.PushUI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32StoreOpcode opcode, WasmFunctionState state) {
            var val = state.PopUI32();
            var adr = state.PopUI32();
            state.Memory.WriteUInt32(adr, opcode.Immediate, val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Store8Opcode opcode, WasmFunctionState state) {
            var val = state.PopUI32();
            var adr = state.PopUI32();
            state.Memory.WriteUInt8(adr, opcode.Immediate, (byte)val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32Store16Opcode opcode, WasmFunctionState state) {
            var val = state.PopUI32();
            var adr = state.PopUI32();
            state.Memory.WriteUInt16(adr, opcode.Immediate, (ushort)val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64LoadOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt64(adr, opcode.Immediate);
            state.PushUI64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load8SOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt8(adr, opcode.Immediate);
            state.PushSI64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load8UOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt8(adr, opcode.Immediate);
            state.PushUI64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load16SOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt16(adr, opcode.Immediate);
            state.PushSI64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load16UOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt16(adr, opcode.Immediate);
            state.PushUI64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load32SOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadSInt32(adr, opcode.Immediate);
            state.PushSI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Load32UOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadUInt32(adr, opcode.Immediate);
            state.PushUI32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64StoreOpcode opcode, WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt64(adr, opcode.Immediate, val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Store8Opcode opcode, WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt8(adr, opcode.Immediate, (byte)val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Store16Opcode opcode, WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt16(adr, opcode.Immediate, (ushort)val);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64Store32Opcode opcode, WasmFunctionState state) {
            var val = state.PopUI64();
            var adr = state.PopUI32();
            state.Memory.WriteUInt32(adr, opcode.Immediate, (uint)val);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32LoadOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadFloat32(adr, opcode.Immediate);
            state.PushF32(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32StoreOpcode opcode, WasmFunctionState state) {
            var val = state.PopF32();
            var adr = state.PopUI32();
            state.Memory.WriteFloat32(adr, opcode.Immediate, val);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64LoadOpcode opcode, WasmFunctionState state) {
            var adr = state.PopUI32();
            var val = state.Memory.ReadFloat64(adr, opcode.Immediate);
            state.PushF64(val);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64StoreOpcode opcode, WasmFunctionState state) {
            var val = state.PopF64();
            var adr = state.PopUI32();
            state.Memory.WriteFloat64(adr, opcode.Immediate, val);
            return this;
        }

        public WasmOpcodeExecutor Visit(MemorySizeOpcode opcode, WasmFunctionState state) {
            state.PushUI32(state.Memory.SizeUnits);
            return this;
        }

        public WasmOpcodeExecutor Visit(MemoryGrowOpcode opcode, WasmFunctionState state) {
            var val = state.PopUI32();
            state.PushUI32(state.Memory.Resize(val));
            return this;
        }

    }
}