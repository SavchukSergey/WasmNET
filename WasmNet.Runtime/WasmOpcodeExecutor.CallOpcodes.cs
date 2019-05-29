using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(CallOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

        public WasmOpcodeExecutor Visit(CallIndirectOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

    }
}