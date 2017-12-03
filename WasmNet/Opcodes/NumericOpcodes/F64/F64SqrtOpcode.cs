using System;

namespace WasmNet.Opcodes {
    public class F64SqrtOpcode : F64UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double arg) => Math.Sqrt(arg);

        public override string ToString() => "f64.sqrt";

    }
}
