using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public static class WasmOpcodeExt {

        private static WasmOpcodeExecutor _executor = new WasmOpcodeExecutor();

        public static void Execute(this BaseOpcode opcode, WasmFunctionState state) {
            opcode.AcceptVistor(_executor, state);
        }

    }
}
