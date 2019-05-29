﻿namespace WasmNet.Opcodes {
    public class F64GtOpcode : ComparisionOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => "f64.gt";

    }
}
