using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(UnreachableOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

        public WasmOpcodeExecutor Visit(NopOpcode opcode, WasmFunctionState state) {
            return this;
        }

        public WasmOpcodeExecutor Visit(BlockOpcode opcode, WasmFunctionState state) {
            state.PushLabel(opcode.Signature);
            return this;
        }

        public WasmOpcodeExecutor Visit(LoopOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(IfOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(ElseOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(EndOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(BrOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(BrIfOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(BrTableOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(ReturnOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

    }
}