using System;
using WasmNet.Opcodes;

namespace WasmNet.Runtime {
    public partial class WasmOpcodeExecutor : IWasmOpcodeVisitor<WasmFunctionState, WasmOpcodeExecutor> {
      
        public WasmOpcodeExecutor Visit(F32AbsOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Abs(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32NegOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(-value);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32CeilOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Ceiling(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32FloorOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Floor(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32TruncOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Truncate(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32NearestOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Round(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32SqrtOpcode opcode, WasmFunctionState state) {
            var value = state.PopF32();
            state.PushF32(MathF.Sqrt(value));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32AddOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(left + right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32SubOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(left - right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32MulOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(left * right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32DivOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(left / right);
            return this;
        }

        public WasmOpcodeExecutor Visit(F32MinOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(MathF.Min(left, right));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32MaxOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(MathF.Max(left, right));
            return this;
        }

        public WasmOpcodeExecutor Visit(F32CopySignOpcode opcode, WasmFunctionState state) {
            var right = state.PopF32();
            var left = state.PopF32();
            state.PushF32(right >= 0 ? MathF.Abs(left) : -MathF.Abs(left));
            return this;
        }

    }
}