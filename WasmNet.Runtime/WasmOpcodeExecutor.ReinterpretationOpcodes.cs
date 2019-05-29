using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
        public WasmOpcodeExecutor Visit(I32ReinterpretF32Opcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64ReinterpretF64Opcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(F32ReinterpretI32Opcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(F64ReinterpretI64Opcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
    }
}