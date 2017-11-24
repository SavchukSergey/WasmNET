namespace WasmNet.Opcodes {
    public class I64StoreOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.store {Address}";

    }
}
