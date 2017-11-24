namespace WasmNet.Opcodes {
    public class I32StoreOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.store {Address}";

    }
}
