using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(I32EqzOpcode opcode, WasmFunctionState state) {
            var value = state.PopUI32();
            state.PushBool(value == 0);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32EqOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left == right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32NeOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left != right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32LtsOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32LtuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32GtsOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32GtuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32LesOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32LeuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32GesOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushBool(left >= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32GeuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushBool(left >= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64EqzOpcode opcode, WasmFunctionState state) {
            var value = state.PopUI64();
            state.PushBool(value == 0);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64EqOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left == right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64NeOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left != right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64LtsOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64LtuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64GtsOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64GtuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64LesOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64LeuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64GesOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushBool(left >= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64GeuOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushBool(left >= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32EqOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left == right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32NeOpcode opcode, WasmFunctionState state){
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left != right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32LtOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32GtOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32LeOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32GeOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushBool(left >= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64EqOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left == right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64NeOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left != right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64LtOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left < right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64GtOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left > right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64LeOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left <= right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64GeOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushBool(left >= right);
            return this;
        }

    }
}