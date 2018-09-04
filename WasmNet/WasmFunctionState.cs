using System;
using System.Collections.Generic;
using System.Linq;
using WasmNet.Data;

namespace WasmNet {
    public class WasmFunctionState {

        private Stack<WasmStackEntry> _stack = new Stack<WasmStackEntry>();

        public int InstructionPointer { get; set; }

        public WasmModuleInstance ModuleInstance { get; set; }

        public WasmType PeekType() => throw new NotImplementedException();

        public void PushLabel(WasmType signature) {
        }

        public void PushSI32(int value) {
            _stack.Push(new WasmStackEntry {
                UInt32 = (uint)value,
                Type = WasmType.I32
            });
        }

        public void PushUI32(int value) {
            _stack.Push(new WasmStackEntry {
                UInt32 = (uint)value,
                Type = WasmType.I32
            });
        }

        public void PushUI32(uint value) {
            _stack.Push(new WasmStackEntry {
                UInt32 = value,
                Type = WasmType.I32
            });
        }

        public void PushSI64(long value) {
            _stack.Push(new WasmStackEntry {
                UInt64 = (ulong)value,
                Type = WasmType.I64
            });
        }

        public void PushUI64(ulong value) {
            _stack.Push(new WasmStackEntry {
                UInt64 = value,
                Type = WasmType.I64
            });
        }

        public void PushF32(float value) {

        }

        public void PushF64(double value) {

        }

        public int PopSI32() {
            return 0;
        }

        public uint PopUI32() {
            var value = _stack.Pop();
            if (value.Type != WasmType.I32) {
                throw new WasmFormatException("Expected stack i32 entry");
            }
            return value.UInt32;
        }

        public long PopSI64() {
            return 0;
        }

        public ulong PopUI64() {
            return 0;
        }

        public float PopF32() {
            return 0;
        }

        public double PopF64() {
            return 0;
        }

        public bool StackEmpty => !_stack.Any();

        public WasmMemory Memory => throw new NotImplementedException();

        public WasmVariable ResolveLocalVariable(uint index) {
            return _locals[(int)index];
        }

        public WasmVariable ResolveGlobalVariable(uint index) {
            throw new NotImplementedException();
        }

        public WasmFunctionState(WasmFunctionSignature signature, WasmFunctionBody body) {
            var locals = (uint)signature.Parameters.Count;
            foreach (var loc in body.Locals) {
                locals += loc.Count;
            }
            _locals = new List<WasmVariable>((int)locals);
            for (var i = 0; i < locals; i++) {
                _locals.Add(new WasmVariable());
            }
        }

        private readonly IList<WasmVariable> _locals;

    }

    public struct WasmStackEntry {

        public uint UInt32;

        public ulong UInt64;

        public WasmType Type;

    }

}
