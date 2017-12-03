using System;

namespace WasmNet.Opcodes {
    public class F32CeilOpcode : F32UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(float arg) => Math.Ceiling(arg);

        public override string ToString() => "f32.ceil";

    }
}
