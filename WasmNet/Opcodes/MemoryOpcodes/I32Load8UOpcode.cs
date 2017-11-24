namespace WasmNet.Opcodes {
    public class I32Load8UOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.load8_u {Address}";

    }
}
