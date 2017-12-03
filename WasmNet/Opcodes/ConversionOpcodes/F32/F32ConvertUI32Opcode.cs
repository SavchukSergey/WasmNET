﻿namespace WasmNet.Opcodes {
    public class F32ConvertUI32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var value = state.PopUI32();
            state.PushF32(value);
        }

        public override string ToString() => "f32.convert_u/i32";

    }
}
