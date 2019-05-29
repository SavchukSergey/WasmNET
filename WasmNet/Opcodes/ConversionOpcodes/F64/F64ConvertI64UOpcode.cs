﻿namespace WasmNet.Opcodes {
    public class F64ConvertI64UOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var value = state.PopUI64();
            state.PushF64(value);
        }

        public override string ToString() => "f64.convert_i64_u";

    }
}