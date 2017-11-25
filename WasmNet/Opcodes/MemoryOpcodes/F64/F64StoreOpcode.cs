namespace WasmNet.Opcodes {
    public class F64StoreOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"f64.store {Address}";

    }
}
