using System;

namespace WasmNet.Opcodes {
    public class F32NearestOpcode : F32UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override float Execute(float arg) => (float)Math.Round(arg);


        public override string ToString() => "f32.nearest";

    }
}
