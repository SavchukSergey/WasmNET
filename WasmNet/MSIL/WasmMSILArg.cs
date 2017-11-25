using System;
using System.Linq;
using System.Reflection.Emit;

namespace WasmNet.MSIL {
    public class WasmMSILArg {

        public WasmMSILArg(WasmFunctionSignature sig) {
            Method = new DynamicMethod("name", Convert(sig.Return), sig.Parameters.Select(p => Convert(p)).ToArray(), false);
            IL = Method.GetILGenerator();
        }

        public DynamicMethod Method { get; }

        public ILGenerator IL { get; }

        private Type Convert(WasmType? type) {
            switch (type) {
                case null: return typeof(void);
                case WasmType.BlockType: return typeof(void);
                case WasmType.I32: return typeof(int);
                case WasmType.I64: return typeof(long);
                case WasmType.F32: return typeof(float);
                case WasmType.F64: return typeof(double);
                default:
                    throw new WasmMSILCompilationException($"unknown type {type}");
            }
        }
    }
}
