namespace WasmNet.Opcodes {
    public class I64Load8SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load8_s {Address}";

    }
}
