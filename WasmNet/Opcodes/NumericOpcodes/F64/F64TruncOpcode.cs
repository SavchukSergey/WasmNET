using System;

namespace WasmNet.Opcodes {
    public class F64TruncOpcode : F64UnaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double arg) => Math.Truncate(arg);

        public override string ToString() => "f64.trunc";

    }
}
