namespace WasmNet.Opcodes {
    public class F32StoreOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"f32.store {Address}";

    }
}
