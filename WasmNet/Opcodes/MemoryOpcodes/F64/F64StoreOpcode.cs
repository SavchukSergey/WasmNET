using WasmNet.Data;

namespace WasmNet.Opcodes {
    public class F64StoreOpcode : MemoryStoreOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override TResult AcceptVistor<TArg, TResult>(IWasmOpcodeVisitor<TArg, TResult> visitor, TArg arg) {
            return visitor.Visit(this, arg);
        }

        public override string ToString() => $"f64.store {Address}";

    }
}
