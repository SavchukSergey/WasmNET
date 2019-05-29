using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(I32ConstOpcode opcode, WasmFunctionState state) {
            state.PushSI32(opcode.Value);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64ConstOpcode opcode, WasmFunctionState state) {
            state.PushSI64(opcode.Value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32ConstOpcode opcode, WasmFunctionState state) {
            state.PushF32(opcode.Value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64ConstOpcode opcode, WasmFunctionState state) {
            state.PushF64(opcode.Value);
            return this;
        }

    }
}