namespace WasmNet.Opcodes {
    public class I64Load32SOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load32_s {Address}";

    }
}
