using System;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
        public WasmOpcodeExecutor Visit(F64AbsOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Abs(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64NegOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(-value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64CeilOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Ceiling(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64FloorOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Floor(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64TruncOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Truncate(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64NearestOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Round(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64SqrtOpcode opcode, WasmFunctionState state) {
            var value = state.PopF64();
            state.PushF64(Math.Sqrt(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64AddOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(left + right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64SubOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(left - right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64MulOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(left * right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64DivOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F64MinOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(Math.Min(left, right));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64MaxOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(Math.Max(left, right));
            return this;
        }

        public WasmOpcodeExecutor Visit(F64CopySignOpcode opcode, WasmFunctionState state) {
            var right = state.PopF64();
            var left = state.PopF64();
            state.PushF64(right >= 0 ? Math.Abs(left) : -Math.Abs(left));
            return this;
        }

    }
}