namespace WasmNet.Opcodes {
    public class I32Load8SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i32.load8_s {Address}";

    }
}
