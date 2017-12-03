using System;
using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class DropOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            switch (state.PeekType()) {
                case WasmType.I32:
                    state.PopUI32();
                    break;
                case WasmType.I64:
                    state.PopUI64();
                    break;
                case WasmType.F32:
                    state.PopF32();
                    break;
                case WasmType.F64:
                    state.PopF64();
                    break;
                default:
                    throw new InvalidOperationException($"cannot drop {state.PeekType()} value");
            }
        }

        public override string ToString() => "drop";

    }
}
