using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
        public WasmOpcodeExecutor Visit(I32TruncF32SOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushSI32((int)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32TruncF32UOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushUI32((uint)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32TruncF64SOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushSI32((int)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32TruncF64UOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushUI32((uint)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32WrapI64Opcode opcode, WasmFunctionState state) {
            var arg = state.PopUI64();
            state.PushUI32((uint)arg);
            return this;
        }


        public WasmOpcodeExecutor Visit(I64ExtendI32SOpcode opcode, WasmFunctionState state)  {
            var arg = state.PopSI32();
            state.PushSI64(arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64ExtendI32UOpcode opcode, WasmFunctionState state) {
            var arg = state.PopUI32();
            state.PushUI64(arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64TruncF32SOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushSI64((long)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64TruncF32UOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushUI64((ulong)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64TruncF64SOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushSI64((long)arg);
            return this;

        }

        public WasmOpcodeExecutor Visit(I64TruncF64UOpcode opcode, WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushUI64((ulong)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32ConvertI32SOpcode opcode, WasmFunctionState state) {
            var value = state.PopSI32();
            state.PushF32(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32ConvertI32UOpcode opcode, WasmFunctionState state) {
            var value = state.PopUI32();
            state.PushF32(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32ConvertI64SOpcode opcode, WasmFunctionState state) {
            var value = state.PopSI64();
            state.PushF32(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32ConvertI64UOpcode opcode, WasmFunctionState state) {
            var value = state.PopUI64();
            state.PushF32(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32DemoteF64Opcode opcode, WasmFunctionState state) {
            var arg = state.PopF64();
            state.PushF32((float)arg);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64ConvertI32SOpcode opcode, WasmFunctionState state) {
            var value = state.PopSI32();
            state.PushF64(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64ConvertI32UOpcode opcode, WasmFunctionState state)  {
            var value = state.PopUI32();
            state.PushF64(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64ConvertI64SOpcode opcode, WasmFunctionState state) {
            var value = state.PopSI64();
            state.PushF64(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64ConvertI64UOpcode opcode, WasmFunctionState state) {
            var value = state.PopUI64();
            state.PushF64(value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64PromoteF32Opcode opcode, WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushF64(arg);
            return this;
        }
    }
}