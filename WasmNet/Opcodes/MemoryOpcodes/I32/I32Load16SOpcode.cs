namespace WasmNet.Opcodes {
    public class I32Load16SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.load16_s {Address}";

    }
}
