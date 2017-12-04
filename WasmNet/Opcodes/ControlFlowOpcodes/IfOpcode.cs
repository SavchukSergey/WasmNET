using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class IfOpcode : BaseOpcode {

        public WasmType Signature { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override void Execute(WasmFunctionState state) => throw new System.NotImplementedException();

        public override string ToString() => $"if {Signature}";

    }
}
