using WasmNet.Data;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
        
        public WasmOpcodeExecutor Visit(LocalGetOpcode opcode, WasmFunctionState state)  {
            var variable = state.ResolveLocalVariable(opcode.LocalIndex);
            switch(variable.Type) {
                case WasmType.I32:
                    state.PushUI32(variable.UInt32);
                    break;
                case WasmType.I64:
                    state.PushUI64(variable.UInt64);
                    break;
                case WasmType.F32:
                    state.PushF32(variable.Float32);
                    break;
                case WasmType.F64:
                    state.PushF64(variable.Float64);
                    break;
            }
            return this;
        }

        public WasmOpcodeExecutor Visit(LocalSetOpcode opcode, WasmFunctionState state) {
            var variable = state.ResolveLocalVariable(opcode.LocalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    variable.UInt32 = state.PopUI32();
                    break;
                case WasmType.I64:
                    variable.UInt64 = state.PopUI64();
                    break;
                case WasmType.F32:
                    variable.Float32 = state.PopF32();
                    break;
                case WasmType.F64:
                    variable.Float64 = state.PopF64();
                    break;
            }
            return this;
        }

        public WasmOpcodeExecutor Visit(LocalTeeOpcode opcode, WasmFunctionState state) {
            var variable = state.ResolveLocalVariable(opcode.LocalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    variable.UInt32 = state.PopUI32();
                    state.PushUI32(variable.UInt32);
                    break;
                case WasmType.I64:
                    variable.UInt64 = state.PopUI64();
                    state.PushUI64(variable.UInt64);
                    break;
                case WasmType.F32:
                    variable.Float32 = state.PopF32();
                    state.PushF32(variable.Float32);
                    break;
                case WasmType.F64:
                    variable.Float64 = state.PopF64();
                    state.PushF64(variable.Float64);
                    break;
            }
            return this;
        }

        public WasmOpcodeExecutor Visit(GlobalGetOpcode opcode, WasmFunctionState state){
            var variable = state.ResolveGlobalVariable(opcode.GlobalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    state.PushUI32(variable.UInt32);
                    break;
                case WasmType.I64:
                    state.PushUI64(variable.UInt64);
                    break;
                case WasmType.F32:
                    state.PushF32(variable.Float32);
                    break;
                case WasmType.F64:
                    state.PushF64(variable.Float64);
                    break;
            }
            return this;
        }

        public WasmOpcodeExecutor Visit(GlobalSetOpcode opcode, WasmFunctionState state) {
            var variable = state.ResolveGlobalVariable(opcode.GlobalIndex);
            switch (variable.Type) {
                case WasmType.I32:
                    variable.UInt32 = state.PopUI32();
                    break;
                case WasmType.I64:
                    variable.UInt64 = state.PopUI64();
                    break;
                case WasmType.F32:
                    variable.Float32 = state.PopF32();
                    break;
                case WasmType.F64:
                    variable.Float64 = state.PopF64();
                    break;
            }
            return this;
        }

    }
}