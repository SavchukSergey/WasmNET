﻿using System;

namespace WasmNet.Opcodes {
    public class F32CopySignOpcode : F32BinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override float Execute(float left, float right) => right >= 0 ? Math.Abs(left) : -Math.Abs(left);

        public override string ToString() => "f32.copysign";

    }
}
