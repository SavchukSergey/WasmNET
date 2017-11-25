namespace WasmNet.Opcodes {
    public class I64Store32Opcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.store32 {Address}";

    }
}
