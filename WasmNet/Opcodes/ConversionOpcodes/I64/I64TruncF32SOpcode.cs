﻿namespace WasmNet.Opcodes {
    public class I64TruncF32SOpcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "i64.trunc_f32_s";

    }
}
