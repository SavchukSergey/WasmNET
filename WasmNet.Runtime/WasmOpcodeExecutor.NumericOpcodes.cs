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
        
        public WasmOpcodeExecutor Visit(F64MinOpcode opcode, WasmFunctionState state)  {
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