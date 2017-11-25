namespace WasmNet.Opcodes {
    public class I64Load16SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load16_s {Address}";

    }
}
