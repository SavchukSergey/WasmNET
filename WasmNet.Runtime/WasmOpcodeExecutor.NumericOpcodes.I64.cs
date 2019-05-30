using System;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {

        public WasmOpcodeExecutor Visit(I64ClzOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64CtzOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64PopCntOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64AddOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left + right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64SubOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left - right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64MulOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left * right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64DivSOpcode opcode, WasmFunctionState state)  {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushSI64(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64DivUOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64RemSOpcode opcode, WasmFunctionState state)  {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushSI64(left % right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64RemUOpcode opcode, WasmFunctionState state)  {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left % right);
            return this;
        }
        
        public WasmOpcodeExecutor Visit(I64AndOpcode opcode, WasmFunctionState state){
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left & right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64OrOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left | right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64XorOpcode opcode, WasmFunctionState state) {
            var right = state.PopUI64();
            var left = state.PopUI64();
            state.PushUI64(left ^ right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64ShlOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        
        public WasmOpcodeExecutor Visit(I64ShrSOpcode opcode, WasmFunctionState state) {
            var right = state.PopSI64();
            var left = state.PopSI64();
            state.PushSI64(left >> (int)right);
            return this;
        }

        public WasmOpcodeExecutor Visit(I64ShrUOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64RotlOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();
        public WasmOpcodeExecutor Visit(I64RotrOpcode opcode, WasmFunctionState state) => throw new System.NotImplementedException();

    }
}