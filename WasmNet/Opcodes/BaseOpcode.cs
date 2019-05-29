using System;
using WasmNet.Data;

namespace WasmNet.Opcodes {
    public abstract class BaseOpcode {

        public abstract TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg);

        public abstract void Execute(WasmFunctionState state);

        protected string Format(WasmBlockType type) {
            switch (type) {
                case WasmBlockType.I32:
                    return "i32";
                case WasmBlockType.I64:
                    return "i64";
                case WasmBlockType.F32:
                    return "f32";
                case WasmBlockType.F64:
                    return "f64";
                case WasmBlockType.Void:
                    return "";
                default:
                    throw new InvalidOperationException($"Unsupported WasmBlockType {type}");
            }
        }

    }
}
