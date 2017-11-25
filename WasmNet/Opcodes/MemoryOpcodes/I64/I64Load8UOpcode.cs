namespace WasmNet.Opcodes {
    public class I64Load8UOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load8_u {Address}";

    }
}
