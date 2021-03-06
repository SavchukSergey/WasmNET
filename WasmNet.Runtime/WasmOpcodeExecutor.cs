using System;
using WasmNet.Data;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(DropOpcode opcode, WasmFunctionState state) {
            state.PopVoid();
            return this;
        }

        public WasmOpcodeExecutor Visit(SelectOpcode opcode, WasmFunctionState state) {
            var condition = state.PopUI32();
            switch (state.PeekType()) {
                case WasmType.I32:
                    var i32right = state.PopUI32();
                    var i32left = state.PopUI32();
                    state.PushUI32(condition != 0 ? i32left : i32right);
                    break;
                case WasmType.I64:
                    var i64right = state.PopUI64();
                    var i64left = state.PopUI64();
                    state.PushUI64(condition != 0 ? i64left : i64right);
                    break;
                case WasmType.F32:
                    var f32right = state.PopF32();
                    var f32left = state.PopF32();
                    state.PushF32(condition != 0 ? f32left : f32right);
                    break;
                case WasmType.F64:
                    var f64right = state.PopF64();
                    var f64left = state.PopF64();
                    state.PushF64(condition != 0 ? f64left : f64right);
                    break;
                default:
                    throw new InvalidOperationException($"cannot select from {state.PeekType()} values");
            }
            return this;
        }

        public WasmOpcodeExecutor Visit(BaseOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
    }
}