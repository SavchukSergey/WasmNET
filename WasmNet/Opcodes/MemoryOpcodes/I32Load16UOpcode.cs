namespace WasmNet.Opcodes {
    public class I32Load16UOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.load16_u {Address}";

    }
}
