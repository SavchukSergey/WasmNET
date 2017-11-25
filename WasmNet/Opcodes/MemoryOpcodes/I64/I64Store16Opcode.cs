namespace WasmNet.Opcodes {
    public class I64Store16Opcode : BaseOpcode {

        public WasmMemoryImmediate Address { get; set; }

        public override string ToString() => $"i64.store16 {Address}";

    }
}
