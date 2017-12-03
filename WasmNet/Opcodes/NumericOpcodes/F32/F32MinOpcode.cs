using System;

namespace WasmNet.Opcodes {
    public class F32MinOpcode : F32BinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(float left, float right) => Math.Min(left, right);

        public override string ToString() => "f32.min";

    }
}
