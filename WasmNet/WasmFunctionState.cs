using System;
using WasmNet.Data;

namespace WasmNet {
    public class WasmFunctionState {

        public int InstructionPointer { get; set; }

        public WasmModuleInstance Module { get; set; }

        public WasmType PeekType() => throw new NotImplementedException();

        public void PushLabel(WasmType signature) {
        }

        public void PushSI32(int value) {
        }

        internal void PushUI32(object sizeUnits) => throw new NotImplementedException();

        public void PushUI32(uint value) {
        }

        public void PushSI64(long value) {

        }

        public void PushUI64(ulong value) {

        }

        public void PushF32(float value) {

        }

        public void PushF64(double value) {

        }

        public int PopSI32() {
            return 0;
        }

        public uint PopUI32() {
            return 0;
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

        public WasmMemory Memory => throw new NotImplementedException();

        public WasmVariable ResolveLocalVariable(uint index) {
            throw new NotImplementedException();
        }

        public WasmVariable ResolveGlobalVariable(uint index) {
            throw new NotImplementedException();
        }

    }
}
