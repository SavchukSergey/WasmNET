using System;

namespace WasmNet.Opcodes {
    public class F64MinOpcode : F64BinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double left, double right) => Math.Min(left, right);

        public override string ToString() => "f64.min";

    }
}
