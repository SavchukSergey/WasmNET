using System;

namespace WasmNet.Opcodes {
    public class F64CopySignOpcode : F64BinaryNumericOpcode {

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        protected override double Execute(double left, double right) => right >= 0 ? Math.Abs(left) : -Math.Abs(left);


        public override string ToString() => "f64.copysign";

    }
}
