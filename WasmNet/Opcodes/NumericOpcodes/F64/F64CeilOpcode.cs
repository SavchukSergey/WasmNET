using System;

namespace WasmNet.Opcodes {
    public class F64CeilOpcode : F64UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double arg) => Math.Ceiling(arg);

        public override string ToString() => "f64.ceil";

    }
}
