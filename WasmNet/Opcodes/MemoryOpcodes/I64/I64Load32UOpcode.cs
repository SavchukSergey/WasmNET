namespace WasmNet.Opcodes {
    public class I64Load32UOpcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.load32_u {Address}";

    }
}
