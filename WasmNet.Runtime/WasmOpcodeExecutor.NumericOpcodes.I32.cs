using System;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
        public WasmOpcodeExecutor Visit(I32ClzOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I32CtzOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I32PopCntOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

        public WasmOpcodeExecutor Visit(I32AddOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left + right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32SubOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left - right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32MulOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left * right);
            return this;
        }
        
        public WasmOpcodeExecutor Visit(I32DivSOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushSI32(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32DivUOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32RemSOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushSI32(left % right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32RemUOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left % right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32AndOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left & right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32OrOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left | right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32XorOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left ^ right);
            return this;
        }
        
        public WasmOpcodeExecutor Visit(I32ShlOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushSI32(left << right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32ShrSOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI32();
            var left = state.PopSI32();
            state.PushSI32(left >> right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32ShrUOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI32();
            var left = state.PopUI32();
            state.PushUI32(left >> (int)right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I32RotlOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I32RotrOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

    }
}