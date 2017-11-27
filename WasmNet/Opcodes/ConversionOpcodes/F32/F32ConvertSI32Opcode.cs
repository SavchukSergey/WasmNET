﻿namespace WasmNet.Opcodes {
    public class F32ConvertSI32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "f32.convert_s/i32";

    }
}