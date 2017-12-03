﻿namespace WasmNet.Opcodes {
    public class I64TruncSF32Opcode : BaseOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) {
            var arg = state.PopF32();
            state.PushSI64((long)arg);
        }

        public override string ToString() => "i64.trunc_s/f32";

    }
}
