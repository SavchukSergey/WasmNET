﻿using System;

namespace WasmNet.Opcodes {
    public class F32FloorOpcode : F32UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override float Execute(float arg) => (float)Math.Floor(arg);

        public override string ToString() => "f32.floor";

    }
}
